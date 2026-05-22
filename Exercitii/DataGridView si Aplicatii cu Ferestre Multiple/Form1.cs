using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace DataGridView_si_Aplicatii_cu_Ferestre_Multiple
{
    public partial class Form1: Form
    {
        BindingList<Angajat> angajati = new BindingList<Angajat>();
        public Form1()
        {
            InitializeComponent();
            cmbFiltruDepartament.SelectedIndexChanged += (s, ev) => {
               switch(cmbFiltruDepartament.SelectedItem.ToString())
                {
                    case "Toate":
                        dgvAngajati.DataSource = angajati;
                        break;
                    case "IT":
                        dgvAngajati.DataSource = angajati.Where(angajat => angajat.Departament == "IT").ToList();
                        break;
                    case "Financiar":
                        dgvAngajati.DataSource = angajati.Where(angajat => angajat.Departament == "Financiar").ToList();
                        break;
                    case "HR":
                        dgvAngajati.DataSource = angajati.Where(angajat => angajat.Departament == "HR").ToList();
                        break;
                    case "Vânzări":
                        dgvAngajati.DataSource = angajati.Where(angajat => angajat.Departament == "Vânzări").ToList();
                        break;
                }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvAngajati.DataSource = angajati;
            cmbFiltruDepartament.SelectedIndex = 0;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            FormAngajat formAngajat = new FormAngajat();
            DialogResult rezultat = formAngajat.ShowDialog(null);
            if (rezultat == DialogResult.OK)
            {
                angajati.Add(formAngajat.AngajatRezultat);
                lblStatus.Text = $"Se afișează {angajati.Count} angajați.";
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvAngajati.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nu este selectat niciun angajat.", "Selecție invalidă", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Angajat angajat = angajati[dgvAngajati.SelectedRows[0].Index];
                DialogResult rezultat = MessageBox.Show($"Sunteți sigur că vreți să ștergeți angajatul {angajat.Nume} {angajat.Prenume}?", "Confirmare ștergere", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(rezultat==DialogResult.Yes)
                {
                    angajati.Remove(angajat);
                    lblStatus.Text = $"Ștergere efectuată. Se afișează {angajati.Count} angajați.";
                }
            }
        }

        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (dgvAngajati.SelectedRows.Count==0)
            {
                MessageBox.Show("Nu este selectat niciun angajat.", "Selecție invalidă", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int indexAngajat = dgvAngajati.SelectedRows[0].Index;
                FormAngajat formAngajat = new FormAngajat(angajati[indexAngajat]);
                DialogResult rezultat = formAngajat.ShowDialog(null);
                if (rezultat == DialogResult.OK)
                {
                    angajati[indexAngajat] = formAngajat.AngajatRezultat;
                    lblStatus.Text = $"Modificare efectuată. Se afișează {angajati.Count} angajați.";
                }
            }
        }
    }
}
