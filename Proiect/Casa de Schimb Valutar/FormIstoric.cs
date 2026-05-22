using System;
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

        public FormIstoric(Guid bazaId, Guid tintaId, string textPereche)
        {
            InitializeComponent();
            con = new SqlConnection(DbConfig.ConnectionString);

            this.bazaId = bazaId;
            this.tintaId = tintaId;
            this.textPereche = textPereche;
        }

        private void FormIstoric_Load(object sender, EventArgs e)
        {
            string formatSlashed = textPereche.Replace(" -> ", "/");
            this.Text = "Istoric Curs: " + formatSlashed;

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

            var seriesBuy = chartCursuri.Series["Cumparare"];
            var seriesSell = chartCursuri.Series["Vanzare"];
            seriesBuy.Points.Clear();
            seriesSell.Points.Clear();

            var axis = chartCursuri.ChartAreas["ChartArea1"].AxisX;
            axis.LabelStyle.Format = "dd-MM-yy";
            axis.LabelStyle.Angle = -45;

            foreach (DataRow row in dt.Rows)
            {
                DateTime data = Convert.ToDateTime(row["DATA_CURS"]);
                decimal dbBuy = Convert.ToDecimal(row["VALOARE_BUY"]);
                decimal dbSell = Convert.ToDecimal(row["VALOARE_SELL"]);

                decimal buy = inversat ? 1m / dbSell : dbBuy;
                decimal sell = inversat ? 1m / dbBuy : dbSell;

                dgvCursuri.Rows.Add(data.ToString("dd-MM-yyyy"), buy.ToString("N4"), sell.ToString("N4"));

                seriesBuy.Points.AddXY(data, (double)buy);
                seriesSell.Points.AddXY(data, (double)sell);
            }

            chartCursuri.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "N4";
            chartCursuri.Titles.Clear();
            chartCursuri.Titles.Add("Evolutie curs " + textPereche.Replace(" -> ", "/"));
        }
    }
}