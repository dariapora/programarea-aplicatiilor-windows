using System;

namespace Casa_de_Schimb_Valutar
{
    public class Tranzactie
    {
        public Guid Id { get; set; }
        public string Tip { get; set; }
        public decimal Suma { get; set; }
        public Guid ValutaId { get; set; }
        public string CodValuta { get; set; }
        public DateTime DataTranzactie { get; set; }
        public string NrCardUltim4 { get; set; }
        public string Titular { get; set; }
        public string Status { get; set; }
    }
}
