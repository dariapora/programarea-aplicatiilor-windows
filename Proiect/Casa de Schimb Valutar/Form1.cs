using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace Casa_de_Schimb_Valutar
{
    public partial class Form1 : Form
    {
        readonly SqlConnection con;
        DataTable toateValutele;
        bool actualizandFiltru = false;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(DbConfig.ConnectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopuleazaMonede();
            rbBuy.Checked = true;
            ActualizeazaEtichete();
        }

        private void rbTip_CheckedChanged(object sender, EventArgs e)
        {
            ActualizeazaEtichete();
            txtSumaIntrodusa_TextChanged(sender, e);
        }

        private void ActualizeazaEtichete()
        {
            if (rbBuy.Checked)
            {
                lblValuta1.Text = "Vreau sa cumpar";
                lblValuta2.Text = "cu";
                btnTranzactie.BackColor = Color.YellowGreen;
                btnTranzactie.Text = "CUMPARA";
            }
            else
            {
                lblValuta1.Text = "Vreau sa vand";
                lblValuta2.Text = "pentru";
                btnTranzactie.BackColor = Color.LightCoral;
                btnTranzactie.Text = "VINDE";
            }
        }

        private void PopuleazaMonede()
        {
            string query = "SELECT ID, COD FROM [dbo].[Valute] ORDER BY COD";
            try
            {
                toateValutele = new DataTable();
                new SqlDataAdapter(query, con).Fill(toateValutele);

                if (toateValutele.Rows.Count == 0)
                {
                    MessageBox.Show("Tabela 'Valute' este goala!");
                    return;
                }

                actualizandFiltru = true;

                cbValuta1.DataSource = toateValutele.Copy();
                cbValuta1.DisplayMember = "COD";
                cbValuta1.ValueMember = "ID";

                cbValuta2.DataSource = toateValutele.Copy();
                cbValuta2.DisplayMember = "COD";
                cbValuta2.ValueMember = "ID";
                if (cbValuta2.Items.Count > 1) cbValuta2.SelectedIndex = 1;

                actualizandFiltru = false;
                FiltreazaValute();
            }
            catch (Exception ex) { MessageBox.Show("Eroare incarcare valute: " + ex.Message); }
        }

        private void ValidareValuteDiferite(object sender, EventArgs e)
        {
            FiltreazaValute();
        }   

        private void FiltreazaValute()
        {
            if (actualizandFiltru || toateValutele == null) return;
            if (cbValuta1.SelectedValue == null || cbValuta2.SelectedValue == null) return;

            actualizandFiltru = true;
            try
            {
                string id1 = cbValuta1.SelectedValue.ToString();
                string id2 = cbValuta2.SelectedValue.ToString();

                object valSalvata2 = cbValuta2.SelectedValue;
                cbValuta2.DataSource = FiltreazaTabel(id1);
                cbValuta2.DisplayMember = "COD";
                cbValuta2.ValueMember = "ID";
                cbValuta2.SelectedValue = valSalvata2;

                object valSalvata1 = cbValuta1.SelectedValue;
                cbValuta1.DataSource = FiltreazaTabel(id2);
                cbValuta1.DisplayMember = "COD";
                cbValuta1.ValueMember = "ID";
                cbValuta1.SelectedValue = valSalvata1;
            }
            finally { actualizandFiltru = false; }
        }

        private DataTable FiltreazaTabel(string excludeId)
        {
            DataTable dt = toateValutele.Clone();
            foreach (DataRow row in toateValutele.Rows)
                if (row["ID"].ToString().ToLower() != excludeId.ToLower())
                    dt.ImportRow(row);
            return dt;
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (toateValutele == null) return;
            if (cbValuta1.SelectedValue == null || cbValuta2.SelectedValue == null) return;

            string id1 = cbValuta1.SelectedValue.ToString();
            string id2 = cbValuta2.SelectedValue.ToString();

            actualizandFiltru = true;

            cbValuta1.DataSource = FiltreazaTabel(id1);
            cbValuta1.DisplayMember = "COD";
            cbValuta1.ValueMember = "ID";
            cbValuta1.SelectedValue = Guid.Parse(id2);

            cbValuta2.DataSource = FiltreazaTabel(id2);
            cbValuta2.DisplayMember = "COD";
            cbValuta2.ValueMember = "ID";
            cbValuta2.SelectedValue = Guid.Parse(id1);

            actualizandFiltru = false;

            if (!string.IsNullOrEmpty(txtSumaRezultata.Text))
                txtSumaIntrodusa_TextChanged(sender, e);
        }

        private void btnDeschideIstoric_Click(object sender, EventArgs e)
        {
            Guid v1Id = Guid.Parse(cbValuta1.SelectedValue.ToString());
            Guid v2Id = Guid.Parse(cbValuta2.SelectedValue.ToString());

            FormIstoric f = new FormIstoric(v1Id, v2Id, cbValuta1.Text + " -> " + cbValuta2.Text);
            f.ShowDialog();
        }

        private void btnTranzactie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSumaIntrodusa.Text) || string.IsNullOrEmpty(txtSumaRezultata.Text)
                || txtSumaRezultata.Text == "Fără cotație")
            {
                MessageBox.Show("Introduceti o suma si asigurati-va ca exista un curs disponibil.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtSumaIntrodusa.Text, out decimal sumaIn)) return;
            string rezultatText = txtSumaRezultata.Text.Split(' ')[0];
            if (!decimal.TryParse(rezultatText, System.Globalization.NumberStyles.Number,
                System.Globalization.CultureInfo.CurrentCulture, out decimal sumaOut)) return;

            Guid v1Id = Guid.Parse(cbValuta1.SelectedValue.ToString());
            Guid v2Id = Guid.Parse(cbValuta2.SelectedValue.ToString());
            string cod1 = cbValuta1.Text;
            string cod2 = cbValuta2.Text;
            string tip = rbBuy.Checked ? "CUMPARARE" : "VANZARE";

            if (!GetCurs(v1Id, v2Id, out decimal buy, out decimal sell)) return;
            decimal cursAplicat = rbBuy.Checked ? sell : buy;

            new FormTranzactie(tip, v1Id, cod1, v2Id, cod2, sumaIn, sumaOut, cursAplicat).ShowDialog(this);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (new FormParolaAdmin().ShowDialog(this) == DialogResult.OK)
                new FormAdmin().ShowDialog(this);
        }

        private void txtSumaIntrodusa_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtSumaIntrodusa.Text, out decimal suma))
            {
                txtSumaRezultata.Text = "";
                return;
            }

            Guid v1Id = Guid.Parse(cbValuta1.SelectedValue.ToString());
            Guid v2Id = Guid.Parse(cbValuta2.SelectedValue.ToString());

            try
            {
                if (!GetCurs(v1Id, v2Id, out decimal buy, out decimal sell))
                {
                    txtSumaRezultata.Text = "Fără cotație";
                    return;
                }

                decimal rezultat = rbBuy.Checked ? suma * sell : suma * buy;
                txtSumaRezultata.Text = $"{rezultat:N2} {cbValuta2.Text}";
            }
            catch (Exception ex) { MessageBox.Show("Eroare calcul: " + ex.Message); }
        }
        private bool GetCurs(Guid baza, Guid tinta, out decimal buy, out decimal sell)
        {
            buy = 0m;
            sell = 0m;

            const string query = @"SELECT TOP 1 VALOARE_BUY, VALOARE_SELL FROM [dbo].[Cursuri]
                                   WHERE VALUTA_BAZA = @baza AND VALUTA_TINTA = @tinta
                                   ORDER BY DATA_CURS DESC";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@baza", baza);
                    cmd.Parameters.AddWithValue("@tinta", tinta);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            buy = Convert.ToDecimal(dr["VALOARE_BUY"]);
                            sell = Convert.ToDecimal(dr["VALOARE_SELL"]);
                            return true;
                        }
                    }
                }

                using (SqlCommand cmdInv = new SqlCommand(query, con))
                {
                    cmdInv.Parameters.AddWithValue("@baza", tinta);
                    cmdInv.Parameters.AddWithValue("@tinta", baza);
                    using (SqlDataReader drInv = cmdInv.ExecuteReader())
                    {
                        if (drInv.Read())
                        {
                            decimal invBuy = Convert.ToDecimal(drInv["VALOARE_BUY"]);
                            decimal invSell = Convert.ToDecimal(drInv["VALOARE_SELL"]);
                            buy = 1m / invSell;
                            sell = 1m / invBuy;
                            return true;
                        }
                    }
                }

                return false;
            }
            finally { con.Close(); }
        }
    }
}
