using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatiActiuniEvenimente
{
    class Comanda
    {
        public string NumarComanda { get; }
        public string NumeClient { get; }
        public string EmailClient { get; }
        public List<Produs> Produse { get; }
        public StareComanda Stare { get; set; }
        public DateTime DataPlasare { get; }

        public decimal GetValoareTotala()
        {
            decimal valoareTotala = 0;
            Produse.ForEach(produs => valoareTotala += produs.Cantitate * produs.Pret);
            return valoareTotala;
        }

        public void AdaugaProdus(Produs produs)
        {
            Produse.Add(produs);
        }

        public override string ToString()
        {
            return $"{NumarComanda} {NumeClient} {GetValoareTotala()}";
        }

        public Comanda(string numarComanda, string numeClient, string emailClient, List<Produs> produse)
        {
            NumarComanda = numarComanda;
            NumeClient = numeClient;
            EmailClient = emailClient;
            Produse = produse;
            Stare = StareComanda.Plasata;
            DataPlasare = DateTime.Now;
        }

    }
}
