using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introducere_in_Windows_Forms
{
    public partial class Form1: Form
    {

        List<Contact> listaContacte = new List<Contact>();
        public Form1()
        {
            InitializeComponent();

            txtCautare.TextChanged += (s, ev) => {
                if (txtCautare.Text.Length == 0)
                {
                    RefreshLista();
                    lblStatus.Text = $"Total: {listaContacte.Count} contacte.";
                }
                else
                {
                    string cautat = txtCautare.Text.ToLower();
                    List<Contact> rezultate = listaContacte.Where(contact => contact.Telefon.StartsWith(cautat) || contact.Nume.ToLower().StartsWith(cautat) || contact.Prenume.ToLower().StartsWith(cautat) || contact.Email.StartsWith(cautat)).ToList();
                    RefreshLista(rezultate);
                    lblStatus.Text = $"Se afiseaza {rezultate.Count} din {listaContacte.Count} contacte.";
                }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RefreshLista(List<Contact> listaCautata = null)
        {
            if (listaCautata != null)
            {
                lstContacte.Items.Clear();
                listaCautata.ForEach(contact => lstContacte.Items.Add(contact));
                return;
            }
            lstContacte.Items.Clear();
            listaContacte.ForEach(contact => lstContacte.Items.Add(contact));
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNume.Text)) MessageBox.Show("Introduceti un nume pentru contact.", "Eroare Validare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (string.IsNullOrEmpty(txtPrenume.Text)) MessageBox.Show("Introduceti un prenume pentru contact.", "Eroare Validare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (string.IsNullOrEmpty(txtTelefon.Text)) MessageBox.Show("Introduceti un numar de telefon pentru contact.", "Eroare Validare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Contact contactNou = new Contact();
                if (!string.IsNullOrEmpty(txtEmail.Text)) contactNou.Email = txtEmail.Text.ToLower();
                contactNou.Nume = txtNume.Text;
                contactNou.Prenume = txtPrenume.Text;
                contactNou.Telefon = txtTelefon.Text;
                listaContacte.Add(contactNou);
                txtNume.Text = null;
                txtPrenume.Text = null;
                txtTelefon.Text = null;
                txtEmail.Text = null;
                MessageBox.Show($"Contactul {contactNou.Prenume} {contactNou.Nume} a fost adaugat cu succes.", "Contact adaugat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshLista();
                lblStatus.Text = $"Contact adaugat. Total: {listaContacte.Count} contacte.";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (lstContacte.SelectedItem == null) MessageBox.Show("Niciun contact selectat.", "Eroare Stergere", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                DialogResult confirmare = MessageBox.Show($"Sunteti sigur ca vreti sa stergeti contactul {((Contact)lstContacte.SelectedItem).Prenume} {((Contact)lstContacte.SelectedItem).Nume}? ", "Confirmare Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(confirmare == DialogResult.Yes)
                {
                    listaContacte.Remove((Contact)lstContacte.SelectedItem);
                    RefreshLista();
                    lblStatus.Text = $"Contact sters. Total: {listaContacte.Count} contacte.";
                }
            }
        }
    }
}
