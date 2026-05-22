using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] studenti = new Student[]
            {
                new Student { Nume = "Andrei", Grupa = "311", NotaExamen = 9, NotaLaborator = 10 },
                new Student { Nume = "Elena",  Grupa = "311", NotaExamen = 4, NotaLaborator = 2 },
                new Student { Nume = "Radu",   Grupa = "312", NotaExamen = 7, NotaLaborator = 8 },
                new Student { Nume = "Ioana",  Grupa = "312", NotaExamen = 3, NotaLaborator = 9 }
            };
            foreach (var s in studenti) s.Afiseaza();

            if(studenti.All(s => s.Media.HasValue))
            {
                int promovati = studenti.Count(s => s.Media >= 5);
                double mediaGenerala = studenti.Average(s => s.Media ?? 0);
                Console.WriteLine($"Studenti promovati: {promovati}\n Media Generala: {mediaGenerala}");
            }
            else
            {
                Console.WriteLine("Nu toti studentii au note.");
            }

        }
    }
}
