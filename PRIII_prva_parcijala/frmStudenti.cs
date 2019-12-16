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
    public partial class frmStudenti : Form
    {
        public frmStudenti()
        {
            InitializeComponent();
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatke(InMemoryDb.Studenti);
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            frmNoviStudent frm = new frmNoviStudent();
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                UcitajPodatke(InMemoryDb.Studenti);
            }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            try
            {
                var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
                if (student == null)
                    throw new Exception();


                frmDetaljiStudenta frm = new frmDetaljiStudenta(student);
                frm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Student nije izabran!");
                return;
            }
        }

        void UcitajPodatke(List<Student> Studenti)
        {
            dgvStudenti.DataSource = null;
            double Prosjek = 0;
            if (Studenti.Count != 0)
            {
                foreach (Student item in Studenti)
                    Prosjek += item.ProsjecnaOcjena;
                Prosjek /= Studenti.Count;
                dgvStudenti.DataSource = Studenti;
            }
            lbDetalji.Text = $"Prikazano {Studenti.Count} studenata, a njihov prosjek je {Math.Round(Prosjek, 1)}";
        }
        private void txtBrojIndeksa_TextChanged(object sender, EventArgs e)
        {
            UcitajPodatke(InMemoryDb.StudentiPoBrojuIndeksa(txtBrojIndeksa.Text.ToLower()));
        }
    }
}
