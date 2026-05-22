using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class CasaBilete
    {
        private List<Bilet> bileteVandute = new List<Bilet>();
        public void AdaugaBilet(Bilet b)
        {
            bileteVandute.Add(b);
        }
        public double GetIncasariTotale()
        {
            double incasari = 0;
            bileteVandute.ForEach(bilet => incasari += bilet.CalculeazaPretFinal());
            return incasari;
        }
        public double GetReduceriAcordate()
        {
            double sumaReduceri = 0;
            bileteVandute.ForEach(bilet => sumaReduceri += bilet.GetReducere());
            return sumaReduceri;
        }

        public int GetNumarBiletePerTip<T>() where T : Bilet
        {
            return bileteVandute.OfType<T>().Count();
        }
        public Bilet GetBiletulCelMaiScump()
        {
            return bileteVandute.OrderByDescending(b => b.CalculeazaPretFinal()).FirstOrDefault();
        }
    }
}
