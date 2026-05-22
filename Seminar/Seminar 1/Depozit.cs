using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1 {
    class Depozit {
        string nume;
        List<Material> lista_materiale;
        public int NumarMateriale => lista_materiale.Count;

        public Depozit(string fnume = "Depozit1") {
            nume = fnume;
            lista_materiale = new List<Material>();
        }

        public void adaugaMaterial(Material m) => lista_materiale.Add(m);



        public override string ToString() {
            string sir = $"Depozitul: {nume} are materialele: \n";
            foreach (var item in lista_materiale) sir += item.ToString();
            return sir;
        }
    }

    
}
