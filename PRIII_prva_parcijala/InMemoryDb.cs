using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIII_prva_parcijala
{
    static class InMemoryDb
    {
        public static double BrojacIndeksa { get; set; } = 1;
        public static List<Student> Studenti { get; set; } = new List<Student>();

        static InMemoryDb()
        {
            //Studenti.Add(new Student { Ime = "Tarik", Prezime = "Colakodzic" });
        }

        public static List<Student> StudentiPoBrojuIndeksa(string BrojIndeksa)
        {
            var rezulatat = Studenti.AsQueryable();
            return rezulatat.Where(x => x.BrojIndeksa.ToLower().Contains(BrojIndeksa)).ToList();
        }
    }
}
