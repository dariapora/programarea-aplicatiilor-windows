using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Casa_de_Schimb_Valutar
{
    public partial class FormTranzactie : Form
    {

        readonly string tip;
        readonly Guid valutaBazaId;
        readonly Guid valutaTintaId;
        readonly string codBaza;
        readonly string codTinta;
        readonly decimal sumaIn;
        readonly decimal sumaOut;
        readonly decimal cursAplicat;

        bool formattingCard = false;
        bool formattingExpiry = false;

        public FormTranzactie(string tip, Guid valutaBazaId, string codBaza,
                              Guid valutaTintaId, string codTinta,
                              decimal sumaIn, decimal sumaOut, decimal cursAplicat)
        {
            InitializeComponent();
            this.tip = tip;
            this.valutaBazaId = valutaBazaId;
            this.codBaza = codBaza;
            this.valutaTintaId = valutaTintaId;
            this.codTinta = codTinta;
            this.sumaIn = sumaIn;
            this.sumaOut = sumaOut;
            this.cursAplicat = cursAplicat;
        }

        private void FormTranzactie_Load(object sender, EventArgs e)
        {
            ActualizeazaCardVizual();
        }

        private void txtNrCard_TextChanged(object sender, EventArgs e)
        {
            if (formattingCard) return;
            formattingCard = true;

            string raw = Regex.Replace(txtNrCard.Text, @"\D", "");
            if (raw.Length > 16) raw = raw.Substring(0, 16);

            string formatted = "";
            for (int i = 0; i < raw.Length; i++)
            {
                if (i > 0 && i % 4 == 0) formatted += " ";
                formatted += raw[i];
            }

            txtNrCard.Text = formatted;
            txtNrCard.SelectionStart = formatted.Length;
            formattingCard = false;
            ActualizeazaCardVizual();
        }

        private void txtExpirare_TextChanged(object sender, EventArgs e)
        {
            if (formattingExpiry) return;
            formattingExpiry = true;

            string raw = Regex.Replace(txtExpirare.Text, @"\D", "");
            if (raw.Length > 4) raw = raw.Substring(0, 4);

            string formatted = raw.Length > 2 ? raw.Substring(0, 2) + "/" + raw.Substring(2) : raw;
            txtExpirare.Text = formatted;
            txtExpirare.SelectionStart = formatted.Length;
            formattingExpiry = false;
            ActualizeazaCardVizual();
        }

        private void txtCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void txtTitular_TextChanged(object sender, EventArgs e)
        {
            ActualizeazaCardVizual();
        }

        private void ActualizeazaCardVizual()
        {
            string raw = txtNrCard.Text.Replace(" ", "");
            int digitsShown = raw.Length;

            string cardDisplay = "";
            int digitIdx = 0;
            for (int i = 0; i < 19; i++)
            {
                if (i == 4 || i == 9 || i == 14)
                    cardDisplay += ' ';
                else
                    cardDisplay += digitIdx < digitsShown ? raw[digitIdx++] : '•';
            }

            lblCardNr.Text = cardDisplay;
            lblCardTitular.Text = string.IsNullOrWhiteSpace(txtTitular.Text) ? "TITULAR CARD" : txtTitular.Text.ToUpper();
            lblCardExpirare.Text = "Exp: " + (string.IsNullOrWhiteSpace(txtExpirare.Text) ? "LL/AA" : txtExpirare.Text);
        }

        private bool Valideaza()
        {
            string nrCard = txtNrCard.Text.Replace(" ", "");
            if (nrCard.Length != 16 || !Regex.IsMatch(nrCard, @"^\d{16}$"))
            {
                MessageBox.Show("Numarul cardului trebuie sa contina exact 16 cifre.", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNrCard.Focus();
                return false;
            }

            string titular = txtTitular.Text.Trim();
            if (titular.Length < 3)
            {
                MessageBox.Show("Numele titularului trebuie sa aiba cel putin 3 caractere.", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitular.Focus();
                return false;
            }
            if (!Regex.IsMatch(titular, @"^[a-zA-ZÀ-ɏ\s\-]+$"))
            {
                MessageBox.Show("Numele titularului poate contine doar litere, spatii si cratime.", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitular.Focus();
                return false;
            }

            string expirare = txtExpirare.Text.Trim();
            if (!Regex.IsMatch(expirare, @"^\d{2}/\d{2}$"))
            {
                MessageBox.Show("Data expirarii trebuie sa fie in formatul LL/AA (ex: 12/26).", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExpirare.Focus();
                return false;
            }
            int luna = int.Parse(expirare.Substring(0, 2));
            int an = int.Parse(expirare.Substring(3, 2)) + 2000;
            if (luna < 1 || luna > 12)
            {
                MessageBox.Show("Luna expirarii trebuie sa fie intre 01 si 12.", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExpirare.Focus();
                return false;
            }
            if (an < DateTime.Today.Year || (an == DateTime.Today.Year && luna < DateTime.Today.Month))
            {
                MessageBox.Show("Cardul este expirat. Introduceti un card valid.", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExpirare.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtCVV.Text.Trim(), @"^\d{3}$"))
            {
                MessageBox.Show("CVV-ul trebuie sa contina exact 3 cifre.", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCVV.Focus();
                return false;
            }

            return true;
        }

        private void btnProceseaza_Click(object sender, EventArgs e)
        {
            if (!Valideaza()) return;

            string nrCard = txtNrCard.Text.Replace(" ", "");
            string ultim4 = nrCard.Substring(12, 4);
            string titular = txtTitular.Text.Trim().ToUpper();

            const string sql = @"
                INSERT INTO [dbo].[Tranzactii]
                    (ID, TIP, VALUTA_BAZA_ID, VALUTA_TINTA_ID, SUMA_IN, SUMA_OUT,
                     CURS_APLICAT, NR_CARD_ULTIM4, TITULAR, DATA_TRANZACTIE, STATUS)
                VALUES
                    (NEWID(), @tip, @bazaId, @tintaId, @sumaIn, @sumaOut,
                     @curs, @ultim4, @titular, GETDATE(), 'APROBATA')";

            try
            {
                using (var con = new SqlConnection(DbConfig.ConnectionString))
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@tip", tip);
                    cmd.Parameters.AddWithValue("@bazaId", valutaBazaId);
                    cmd.Parameters.AddWithValue("@tintaId", valutaTintaId);
                    cmd.Parameters.AddWithValue("@sumaIn", sumaIn);
                    cmd.Parameters.AddWithValue("@sumaOut", sumaOut);
                    cmd.Parameters.AddWithValue("@curs", cursAplicat);
                    cmd.Parameters.AddWithValue("@ultim4", ultim4);
                    cmd.Parameters.AddWithValue("@titular", titular);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    $"Tranzactie aprobata!\n\n" +
                    $"{tip}: {sumaIn:N2} {codBaza}  ->  {sumaOut:N2} {codTinta}\n" +
                    $"Curs aplicat: {cursAplicat:N4}\n" +
                    $"Card: **** **** **** {ultim4}\n" +
                    $"Titular: {titular}",
                    "Aprobat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la procesarea tranzactiei: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
