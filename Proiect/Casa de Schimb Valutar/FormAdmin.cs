using System;
using System.Windows.Forms;

namespace Casa_de_Schimb_Valutar
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnTranzactii_Click(object sender, EventArgs e)
        {
            new FormAdminTranzactii().ShowDialog(this);
        }

        private void btnCursuri_Click(object sender, EventArgs e)
        {
            new FormCursuri().ShowDialog(this);
        }
    }
}
