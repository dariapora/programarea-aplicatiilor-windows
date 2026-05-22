using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_de_Schimb_Valutar
{
    internal class Valuta
    {
        public Guid Id { get; set; }
        public string Cod { get; set; }
        public string Nume { get; set; }

        public Valuta() { }

        public Valuta(Guid id, string cod, string nume)
        {
            Id = id;
            Cod = cod;
            Nume = nume;
        }
    }
}
