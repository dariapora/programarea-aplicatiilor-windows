using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView_si_Aplicatii_cu_Ferestre_Multiple
{
    public class Angajat
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Departament { get; set; }

        public decimal Salariu { get; set; }
        public DateTime DataAngajarii { get; set; }
        public bool EstePermanent { get; set; }

        public string GetNumeComplet()
        {
            return $"{Nume} {Prenume}";
        }

        public override string ToString()
        {
            return GetNumeComplet();
        }
    }
}
