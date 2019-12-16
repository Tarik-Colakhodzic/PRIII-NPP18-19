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
    public partial class frmDetaljiStudenta : Form
    {
        public frmDetaljiStudenta(Student student)
        {
            InitializeComponent();
            UcitajPodatke(student);
        }

        void UcitajPodatke(Student student)
        {
            txtBrojIndeksa.Text = student.BrojIndeksa;
            txtIme.Text = student.Ime;
            txtPrezime.Text = student.Prezime;
            txtEmail.Text = student.Email;
            pbSlika.Image = student.Slika;

            dgvPredmeti.DataSource = null;
            dgvPredmeti.DataSource = student.PolozeniPredmeti;
        }
    }
}
