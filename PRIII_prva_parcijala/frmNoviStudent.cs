using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRIII_prva_parcijala
{
    public partial class frmNoviStudent : Form
    {
        public string ObavezanUnos { get; set; } = "Obavezan unos vrijednosti!";
        public frmNoviStudent()
        {
            InitializeComponent();
            txtBrojIndeksa.Text = FormatirajBrojIndeksa();
            txtEmail.Text = txtBrojIndeksa.Text + "@edu.fit.ba";
            txtIme.Focus();
        }


        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (!validiraj())
                return;

            InMemoryDb.BrojacIndeksa++;
            Student novi = new Student()
            {
                BrojIndeksa = txtBrojIndeksa.Text,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Email = txtEmail.Text,
                Slika = pbSlika.Image
            };
            InMemoryDb.Studenti.Add(novi);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        string FormatirajBrojIndeksa()
        {
            string rezultat = "IB190";
            if (InMemoryDb.BrojacIndeksa < 10)
                rezultat += "00" + InMemoryDb.BrojacIndeksa;
            else if (InMemoryDb.BrojacIndeksa < 100)
                rezultat += "0" + InMemoryDb.BrojacIndeksa;
            else
                rezultat += InMemoryDb.BrojacIndeksa;
            return rezultat;
        }

        bool validiraj()
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, ObavezanUnos);
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                errorProvider1.SetError(txtPrezime, ObavezanUnos);
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (pbSlika.Image == null)
            {
                errorProvider1.SetError(pbSlika, ObavezanUnos);
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            return true;
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            try
            {
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}