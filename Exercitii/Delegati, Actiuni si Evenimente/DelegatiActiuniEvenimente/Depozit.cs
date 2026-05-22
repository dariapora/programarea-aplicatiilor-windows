using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DelegatiActiuniEvenimente
{
    class Depozit
    {
        public class ComandaSchimbatStareEventArgs : EventArgs
        {
            public Comanda Comanda { get; set; }
            public StareComanda StareVeche { get; set; }
            public StareComanda StareNoua { get; set; }
        }
        public class ComandaLivrataEventArgs : EventArgs
        {
            public Comanda Comanda { get; set; }
            public DateTime DataLivrare { get; set; }
        }
        public string NumeDepozit { get; set; }
        public List<Comanda> comenzi = new List<Comanda>();

        public event EventHandler<ComandaSchimbatStareEventArgs> ComandaSchimbatStare;
        public event EventHandler<ComandaLivrataEventArgs> ComandaLivrata;

        public void InregistreazaComanda(Comanda c, NotificareService.NotificareClient onNotificareClient = null)
        {
            comenzi.Add(c);
            onNotificareClient?.Invoke(c.NumarComanda, "A fost inregistrata");
        }

        public void AvanseazaStare(string numarComanda)
        {
            Comanda comanda = comenzi.Find(x => x.NumarComanda.Equals(numarComanda));
            if (comanda == null) return;
            StareComanda stareVeche = comanda.Stare;
            switch (comanda.Stare)
            {
                case StareComanda.Plasata:
                    comanda.Stare = StareComanda.Procesata;
                    break;
                case StareComanda.Procesata:
                    comanda.Stare = StareComanda.Expediata;
                    break;
                case StareComanda.Expediata:
                    comanda.Stare = StareComanda.Livrata;
                    break;
            }
            if(stareVeche!=comanda.Stare)
            {
                ComandaSchimbatStare?.Invoke(this, new ComandaSchimbatStareEventArgs { Comanda = comanda, StareNoua = comanda.Stare, StareVeche=stareVeche });
                if (comanda.Stare == StareComanda.Livrata)
                    ComandaLivrata?.Invoke(this, new ComandaLivrataEventArgs { Comanda = comanda, DataLivrare = DateTime.Now });
            }
        }

        public List<Comanda> GetComenziActive()
        {
            List<Comanda> comenziActive = new List<Comanda>();
            comenziActive = comenzi.Where(x => x.Stare != StareComanda.Livrata).ToList();
            return comenziActive;
        }
    }
}
