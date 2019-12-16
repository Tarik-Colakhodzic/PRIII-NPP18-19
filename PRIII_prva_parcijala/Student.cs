using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIII_prva_parcijala
{
    public class Student
    {
        public string BrojIndeksa { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public Image Slika { get; set; }
        public List<Predmet> PolozeniPredmeti { get; set; } = new List<Predmet>();
        public double ProsjecnaOcjena { get; set; } = 0;
        public int BrojPolozenih { get; set; } = 0;

        public Student()
        {
            PolozeniPredmeti.Add(new Predmet { Naziv = "Programiranje III", Ocjena = 10 });
            PolozeniPredmeti.Add(new Predmet { Naziv = "Matematika III", Ocjena = 7 });
            PolozeniPredmeti.Add(new Predmet { Naziv = "Racunarske Mreze", Ocjena = 8 });
            PolozeniPredmeti.Add(new Predmet { Naziv = "Baze podataka I", Ocjena = 9 });
            PolozeniPredmeti.Add(new Predmet { Naziv = "Algoritmi i strukture podataka", Ocjena = 9 });

            BrojPolozenih = PolozeniPredmeti.Count;
            foreach (Predmet item in PolozeniPredmeti)
                ProsjecnaOcjena += item.Ocjena;
            ProsjecnaOcjena /= BrojPolozenih;
        }
    }
}
