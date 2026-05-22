using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_si_Aplicatii_cu_Ferestre_Multiple
{
    public partial class FormAngajat: Form
    {
        ErrorProvider eroare = new ErrorProvider();
        public Angajat AngajatRezultat { get; set; }
        public FormAngajat(Angajat angajat = null)
        {
            InitializeComponent();
            cmbDepartament.SelectedIndex = 0;
            if (angajat != null)
            {
                Text = "Editează Angajat";
                txtNume.Text = angajat.Nume;
                txtPrenume.Text = angajat.Prenume;
                txtSalariu.Text = angajat.Salariu.ToString();
                cmbDepartament.SelectedItem = angajat.Departament;
                dtpDataAngajarii.Value = angajat.DataAngajarii;
                chkEstePermanent.Checked = angajat.EstePermanent;
            }
            Text = "Angajat Nou";
            eroare.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            eroare.Clear();
            if(string.IsNullOrEmpty(txtNume.Text))
            {
                eroare.SetError(txtNume, "Numele nu poate fi gol.");
            }
            else if (string.IsNullOrEmpty(txtPrenume.Text))
            {
                eroare.SetError(txtPrenume, "Prenumele nu poate fi gol.");
            }
            else if(string.IsNullOrEmpty(txtSalariu.Text) || Convert.ToDecimal(txtSalariu.Text) < 0) eroare.SetError(txtSalariu, "Salariul trebuie sa fie pozitiv.");
            else
            {
                AngajatRezultat = new Angajat();
                AngajatRezultat.Salariu = Convert.ToDecimal(txtSalariu.Text);
                AngajatRezultat.DataAngajarii = dtpDataAngajarii.Value;
                AngajatRezultat.Prenume = txtPrenume.Text;
                AngajatRezultat.Nume = txtNume.Text;
                AngajatRezultat.Departament = cmbDepartament.SelectedItem.ToString();
                AngajatRezultat.EstePermanent = chkEstePermanent.Checked;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
