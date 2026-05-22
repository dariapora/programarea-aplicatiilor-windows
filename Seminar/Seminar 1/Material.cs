using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar1 {
    class Material {
        int cod_material, cantitate;
        double pret_unitar;
        string denumire_material, unitate_masura;

        public int Cod_Material {
            get => cod_material;
            set => cod_material = value;
        }

        public int Cantitate {
            get => cantitate;
            set {
                if (value >= 0) cantitate = value; 
            }
        }

        public double Pret_Unitar {
            get => pret_unitar;
            set {
                if (value > 0.0) pret_unitar = value;
            }
        }

        public string Denumire_Material {
            get => denumire_material;
            set {
                if (value.Length > 0) denumire_material = value; 
            }
        }

        public string Unitate_Masura {
            get => unitate_masura;
            set {
                if (value.Length > 0) unitate_masura = value;
            }
        }

        public double Valoare => cantitate * pret_unitar;

        public Material() {
            cod_material = cantitate = 0;
            pret_unitar = 0F;
            denumire_material = unitate_masura = "N/A";
        }

        public override string ToString() => $"Materialul cu codul: {Cod_Material}\n\tDenumire: {Denumire_Material}\n\tCantitate: {Cantitate}\n\tPret Unitar: {Pret_Unitar}\n\tUnitate de masura: {Unitate_Masura}\n\tValoarea:{Valoare}\n";

    
    
    }
}
