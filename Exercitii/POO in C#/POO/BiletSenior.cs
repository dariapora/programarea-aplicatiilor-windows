using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class BiletSenior : Bilet
    {
        int varstaClient;
        public int VarstaClient
        {
            get => varstaClient;
            set
            {
                if (value < 60) throw new ArgumentException("Pentru bilet de senior, trebuie sa aveti varsta de minim 60 de ani.");
                varstaClient = value;
            }
        }
        public override double GetReducere()
        {
            return PretBaza - (0.3 * PretBaza);
        }
        public BiletSenior(int varstaClient, string numeFilm, int numarSala, TipFilm tipFilm, DateTime expiraLa, Client client, int numarLoc, double pretBaza) : base(numeFilm, numarSala, tipFilm, expiraLa, client, numarLoc, pretBaza)
        {
            VarstaClient = varstaClient;
        }
    }
}
