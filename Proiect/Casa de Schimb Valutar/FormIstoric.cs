using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Casa_de_Schimb_Valutar
{
    public partial class FormIstoric : Form
    {
        readonly SqlConnection con;

        private Guid bazaId;
        private Guid tintaId;
        private string textPereche;

        private List<double> valBuy;
        private List<double> valSell;

        public FormIstoric(Guid bazaId, Guid tintaId, string textPereche)
        {
            InitializeComponent();
            con = new SqlConnection(DbConfig.ConnectionString);

            this.bazaId = bazaId;
            this.tintaId = tintaId;
            this.textPereche = textPereche;

            rbCumparare.CheckedChanged += (s, e) => ActualizeazaGrafic();
            rbVanzare.CheckedChanged += (s, e) => ActualizeazaGrafic();
            rbAmbele.CheckedChanged += (s, e) => ActualizeazaGrafic();
        }

        private void FormIstoric_Load(object sender, EventArgs e)
        {
            string formatSlashed = textPereche.Replace(" -> ", "/");
            this.Text = "Istoric Curs: " + formatSlashed;
            lblTitlu.Text = "Evolutia cursului " + formatSlashed;

            IncarcaDate();
        }

        private void IncarcaDate()
        {
            string query = @"SELECT VALOARE_BUY, VALOARE_SELL, DATA_CURS FROM [dbo].[Cursuri]
                             WHERE VALUTA_BAZA = @baza AND VALUTA_TINTA = @tinta
                             ORDER BY DATA_CURS ASC";

            bool inversat = false;
            DataTable dt = new DataTable();

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@baza", bazaId);
                cmd.Parameters.AddWithValue("@tinta", tintaId);
                new SqlDataAdapter(cmd).Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    dt.Clear();
                    SqlCommand cmdInv = new SqlCommand(query, con);
                    cmdInv.Parameters.AddWithValue("@baza", tintaId);
                    cmdInv.Parameters.AddWithValue("@tinta", bazaId);
                    new SqlDataAdapter(cmdInv).Fill(dt);
                    inversat = true;
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nu exista date istorice pentru aceasta pereche.");
                    this.Close();
                    return;
                }
            }
            catch (Exception ex) { MessageBox.Show("Eroare incarcare date: " + ex.Message); return; }
            finally { con.Close(); }

            PopuleazaTabel(dt, inversat);
        }

        private void PopuleazaTabel(DataTable dt, bool inversat)
        {
            dgvCursuri.Columns.Clear();
            dgvCursuri.Columns.Add("Data", "Data");
            dgvCursuri.Columns.Add("Buy", "Curs Cumparare");
            dgvCursuri.Columns.Add("Sell", "Curs Vanzare");

            valBuy = new List<double>();
            valSell = new List<double>();

            foreach (DataRow row in dt.Rows)
            {
                DateTime data = Convert.ToDateTime(row["DATA_CURS"]);
                decimal dbBuy = Convert.ToDecimal(row["VALOARE_BUY"]);
                decimal dbSell = Convert.ToDecimal(row["VALOARE_SELL"]);

                decimal buy = inversat ? 1m / dbSell : dbBuy;
                decimal sell = inversat ? 1m / dbBuy : dbSell;

                dgvCursuri.Rows.Add(data.ToString("dd-MM-yyyy"), buy.ToString("N4"), sell.ToString("N4"));

                valBuy.Add((double)buy);
                valSell.Add((double)sell);
            }

            ActualizeazaGrafic();
        }

        private void ActualizeazaGrafic()
        {
            if (valBuy == null || valSell == null) return;

            var serii = new List<GraficLinie.Serie>();
            bool aratiBuy = rbCumparare.Checked || rbAmbele.Checked;
            bool aratiSell = rbVanzare.Checked || rbAmbele.Checked;

            if (aratiBuy)
                serii.Add(new GraficLinie.Serie { Nume = "Cumparare", Culoare = Color.YellowGreen, Valori = valBuy });
            if (aratiSell)
                serii.Add(new GraficLinie.Serie { Nume = "Vanzare", Culoare = Color.IndianRed, Valori = valSell });

            pnlBuy.Visible = lblBuy.Visible = aratiBuy;
            pnlSell.Visible = lblSell.Visible = aratiSell;

            chartCursuri.SeteazaDate(serii);
        }
    }
}