using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIII_prva_parcijala
{
    public class Predmet
    {
        public string Naziv { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumVrijemePolaganja { get; set; } = DateTime.Now;
    }
}
