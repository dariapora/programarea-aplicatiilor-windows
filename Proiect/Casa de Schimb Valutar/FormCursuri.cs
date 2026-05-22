using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Casa_de_Schimb_Valutar
{
    public partial class FormCursuri : Form
    {

        public FormCursuri()
        {
            InitializeComponent();
        }

        private void FormCursuri_Load(object sender, EventArgs e)
        {
            dgvCursuriExistente.DataSource = bindingSource;
            IncarcaValute();
            IncarcaCursuriExistente();
        }

        private void IncarcaValute()
        {
            try
            {
                var dt = new DataTable();
                using (var con = new SqlConnection(DbConfig.ConnectionString))
                    new SqlDataAdapter("SELECT ID, COD FROM [dbo].[Valute] ORDER BY COD", con).Fill(dt);

                cbValutaBaza.DataSource = dt.Copy();
                cbValutaBaza.DisplayMember = "COD";
                cbValutaBaza.ValueMember = "ID";

                cbValutaTinta.DataSource = dt.Copy();
                cbValutaTinta.DisplayMember = "COD";
                cbValutaTinta.ValueMember = "ID";

                if (cbValutaTinta.Items.Count > 1) cbValutaTinta.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare incarcare valute: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IncarcaCursuriExistente()
        {
            const string q = "SELECT * FROM [dbo].[VW_CursuriRecente] ORDER BY Data DESC";

            try
            {
                var dt = new DataTable();
                using (var con = new SqlConnection(DbConfig.ConnectionString))
                    new SqlDataAdapter(q, con).Fill(dt);

                bindingSource.DataSource = dt;

                if (dgvCursuriExistente.Columns["ID"] != null)
                    dgvCursuriExistente.Columns["ID"].Visible = false;
                if (dgvCursuriExistente.Columns["Buy"] != null)
                    dgvCursuriExistente.Columns["Buy"].DefaultCellStyle.Format = "N4";
                if (dgvCursuriExistente.Columns["Sell"] != null)
                    dgvCursuriExistente.Columns["Sell"].DefaultCellStyle.Format = "N4";
                if (dgvCursuriExistente.Columns["Data"] != null)
                    dgvCursuriExistente.Columns["Data"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare incarcare cursuri: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null) return;

            if (MessageBox.Show("Stergi acest curs?", "Confirmare",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                var row = ((System.Data.DataRowView)bindingSource.Current).Row;
                var id = row["ID"];

                using (var con = new SqlConnection(DbConfig.ConnectionString))
                using (var cmd = new SqlCommand("DELETE FROM [dbo].[Cursuri] WHERE ID = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                bindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la stergere: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (cbValutaBaza.SelectedValue == null || cbValutaTinta.SelectedValue == null)
            {
                MessageBox.Show("Selecteaza ambele valute.", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guid bazaId = Guid.Parse(cbValutaBaza.SelectedValue.ToString());
            Guid tintaId = Guid.Parse(cbValutaTinta.SelectedValue.ToString());

            if (bazaId == tintaId)
            {
                MessageBox.Show("Valuta de baza si valuta de tinta trebuie sa fie diferite.", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal buy = numBuy.Value;
            decimal sell = numSell.Value;

            if (buy <= 0 || sell <= 0)
            {
                MessageBox.Show("Cursurile trebuie sa fie mai mari decat zero.", "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (buy >= sell)
            {
                MessageBox.Show("Cursul BUY trebuie sa fie strict mai mic decat SELL. ",
                                "Validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const string insert = @"INSERT INTO [dbo].[Cursuri]
                (ID, VALUTA_BAZA, VALUTA_TINTA, VALOARE_BUY, VALOARE_SELL, DATA_CURS)
                VALUES (NEWID(), @baza, @tinta, @buy, @sell, GETDATE())";

            try
            {
                using (var con = new SqlConnection(DbConfig.ConnectionString))
                using (var cmd = new SqlCommand(insert, con))
                {
                    cmd.Parameters.AddWithValue("@baza", bazaId);
                    cmd.Parameters.AddWithValue("@tinta", tintaId);
                    cmd.Parameters.AddWithValue("@buy", buy);
                    cmd.Parameters.AddWithValue("@sell", sell);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                numBuy.Value = 0;
                numSell.Value = 0;
                IncarcaCursuriExistente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare salvare curs: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
