using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class BiletStudent : Bilet
    {
        public string NumarLegitimatie { get; set; }
        public string Facultate { get; set; }
        public override double GetReducere()
        {
            return 0.2 * PretBaza;
        }
        public override bool EsteValid()
        {
            if (!base.EsteValid() || string.IsNullOrEmpty(NumarLegitimatie)) return false;
            return true;
        }

        public BiletStudent(string numeFilm, int numarSala, TipFilm tipFilm, DateTime expiraLa, Client client, int numarLoc, double pretBaza, string numarLegitimatie, string facultate) : base(numeFilm, numarSala, tipFilm, expiraLa, client, numarLoc, pretBaza)
        {
            NumarLegitimatie = numarLegitimatie;
            Facultate = facultate;
        }
    }
}
