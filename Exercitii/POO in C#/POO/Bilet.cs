using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Bilet : IPretCalculabil, IValidabil
    {
        public string NumeFilm { get; set; }
        public int NumarSala { get; set; }
        public TipFilm TipFilm { get; set; }
        public DateTime ExpiraLa { get; set; }
        public Client Client { get; set; }
        int numarLoc = 0;
        public int NumarLoc
        {
            get
            {
                return numarLoc;
            }
            set
            {
                if (value < 1 || value > 200) throw new ArgumentException("Numarul locului apartine intervalului 1-200.");
                numarLoc = value;
            }
        }
        double pretBaza;
        public double PretBaza
        {
            get
            {
                return pretBaza;
            }
            set
            {
                if (value <= 0) throw new ArgumentException("Pretul trebuie sa fie >= 0.");
                pretBaza = value;
            }
        }

        public virtual double GetReducere()
        {
            return 0;
        }
        public virtual double CalculeazaPretFinal()
        {
            return PretBaza - GetReducere();
        }
        public virtual bool EsteValid()
        {
            if (ExpiraLa > DateTime.Now && numarLoc > 0) return true;
            return false;
        }
        public Bilet(string numeFilm, int numarSala, TipFilm tipFilm, DateTime expiraLa, Client client, int numarLoc, double pretBaza)
        {
            NumeFilm = numeFilm;
            NumarSala = numarSala;
            TipFilm = tipFilm;
            ExpiraLa = expiraLa;
            Client = client;
            NumarLoc = numarLoc;
            PretBaza = pretBaza;
        }
    }
}
