using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii
{
    internal class Student
    {
        public string Nume { get; set; }
        public string Grupa { get; set; }
        public double? NotaExamen { get; set; }
        public double? NotaLaborator { get; set; }

        public double? Media => (NotaExamen + NotaLaborator) / 2;

        public void Afiseaza()
        {
            Console.WriteLine($"Student: {Nume}\n Grupa: {Grupa}\n Nota Examen: {NotaExamen.ToString() ?? "Indisponibila"}\n Nota Laborator: {NotaLaborator?.ToString() ?? "Indisponibila"}\n Media: {Media?.ToString() ?? "Indisponibila"}");
        }
    }
}
