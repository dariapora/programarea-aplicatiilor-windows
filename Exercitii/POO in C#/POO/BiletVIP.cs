using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class BiletVIP : Bilet
    {
        public bool IncludePopcorn { get; set; }
        public bool IncludeBautura { get; set; }
        public int GetExtras()
        {
            int suma = 0;
            if (IncludeBautura == true) suma += 10;
            if (IncludePopcorn == true) suma += 15;
            return suma;
        }
        public override double CalculeazaPretFinal()
        {
            return PretBaza + GetExtras();
        }
        public BiletVIP(bool popcorn, bool bautura, string numeFilm, int numarSala, TipFilm tipFilm, DateTime expiraLa, Client client, int numarLoc, double pretBaza) : base(numeFilm, numarSala, tipFilm, expiraLa, client, numarLoc, pretBaza)
        {
            IncludePopcorn = popcorn;
            IncludeBautura = bautura;
        }
    }
}
