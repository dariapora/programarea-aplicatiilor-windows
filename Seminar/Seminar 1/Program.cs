using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1 {
    internal class Program {
        static void Main(string[] args) {
            Material material1 = new Material() { Cantitate = 23, Cod_Material = 1, Denumire_Material = "Matase", Pret_Unitar = 12.4, Unitate_Masura = "Grame"};
            //Console.WriteLine(material1.ToString());

            Depozit depozit = new Depozit();
            depozit.adaugaMaterial(material1);
            depozit.adaugaMaterial(new Material() { Cantitate = 15, Cod_Material = 2, Denumire_Material = "Bumbac", Pret_Unitar = 15, Unitate_Masura = "Grame" });
            Console.WriteLine(depozit);
        }
    }
}
