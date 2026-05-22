using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_de_Schimb_Valutar
{
    internal class Curs
    {
        public Guid Id { get; set; }
        public Guid ValutaBazaId { get; set; }
        public Guid ValutaTintaId { get; set; }
        public Valuta ValutaBaza { get; set; }
        public Valuta ValutaTinta { get; set; }

        public DateTime DataCurs { get; set; }
        public decimal ValoareBuy { get; set; }
        public decimal ValoareSell { get; set; }
    }
}
