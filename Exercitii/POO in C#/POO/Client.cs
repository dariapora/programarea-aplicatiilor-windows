using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Client
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if(!(value.Contains('@') && value.Contains('.')))
                {
                    throw new ArgumentException("Adresa de email trebuie sa contina caracterele '@' si '.'.");
                }
                email = value;
            }
        }
        string telefon;
        public string Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                if (value.Length != 10) throw new ArgumentException("Numarul de telefon trebuie sa aiba 10 cifre.");
                telefon = value;
            }
        }
        public Client(string nume, string prenume, string email, string telefon)
        {
            Nume = nume;
            Prenume = prenume;
            Email = email;
            Telefon = telefon;
        }
    }
}
