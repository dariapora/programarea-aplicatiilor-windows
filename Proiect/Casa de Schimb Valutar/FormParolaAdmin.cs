using System;
using System.Windows.Forms;

namespace Casa_de_Schimb_Valutar
{
    public partial class FormParolaAdmin : Form
    {
        public FormParolaAdmin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtParola.Text == "paw2026")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Parola incorecta!", "Acces Refuzat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtParola.Clear();
                txtParola.Focus();
            }
        }
    }
}
