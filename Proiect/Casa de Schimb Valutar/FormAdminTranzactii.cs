using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Casa_de_Schimb_Valutar
{
    public partial class FormAdminTranzactii : Form
    {
        public FormAdminTranzactii()
        {
            InitializeComponent();
        }

        private void FormAdminTranzactii_Load(object sender, EventArgs e)
        {
            dgvTranzactii.DataSource = bindingSource;
            IncarcaTranzactii();
        }

        private void IncarcaTranzactii()
        {
            const string query = "SELECT * FROM [dbo].[VW_Tranzactii] ORDER BY Data DESC";
            try
            {
                var dt = new DataTable();
                using (var con = new SqlConnection(DbConfig.ConnectionString))
                    new SqlDataAdapter(query, con).Fill(dt);

                bindingSource.DataSource = dt;

                if (dgvTranzactii.Columns["ID"] != null)
                    dgvTranzactii.Columns["ID"].Visible = false;
                if (dgvTranzactii.Columns["Suma In"] != null)
                    dgvTranzactii.Columns["Suma In"].DefaultCellStyle.Format = "N2";
                if (dgvTranzactii.Columns["Suma Out"] != null)
                    dgvTranzactii.Columns["Suma Out"].DefaultCellStyle.Format = "N2";
                if (dgvTranzactii.Columns["Curs"] != null)
                    dgvTranzactii.Columns["Curs"].DefaultCellStyle.Format = "N4";
                if (dgvTranzactii.Columns["Data"] != null)
                    dgvTranzactii.Columns["Data"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";

                lblTotal.Text = $"Total tranzactii: {bindingSource.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare incarcare tranzactii: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null) return;

            if (MessageBox.Show("Stergi aceasta tranzactie?", "Confirmare",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                var row = ((DataRowView)bindingSource.Current).Row;
                var id = row["ID"];

                using (var con = new SqlConnection(DbConfig.ConnectionString))
                using (var cmd = new SqlCommand("DELETE FROM [dbo].[Tranzactii] WHERE ID = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                bindingSource.RemoveCurrent();
                lblTotal.Text = $"Total tranzactii: {bindingSource.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la stergere: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReincarca_Click(object sender, EventArgs e)
        {
            IncarcaTranzactii();
        }
    }
}
