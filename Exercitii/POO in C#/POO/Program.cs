using System;
using System.Collections.Generic;
using System.Linq;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CasaBilete casa = new CasaBilete();
                Client ion = new Client("Popescu", "Ion", "ion@yahoo.com", "0722111222");
                DateTime dataFilm = DateTime.Now.AddDays(1);

                casa.AdaugaBilet(new Bilet("Dune 2", 1, TipFilm.Actiune, dataFilm, ion, 50, 30));
                casa.AdaugaBilet(new BiletStudent("Dune 2", 1, TipFilm.Actiune, dataFilm, ion, 51, 30, "ST123", "Politehnica"));
                casa.AdaugaBilet(new BiletSenior(65, "Dune 2", 1, TipFilm.Actiune, dataFilm, ion, 52, 30));
                casa.AdaugaBilet(new BiletVIP(true, true, "Dune 2", 1, TipFilm.Actiune, dataFilm, ion, 10, 50));

                Console.WriteLine("=== Statistica Vanzari Cinema ===");
                Console.WriteLine($"Incasari totale: {casa.GetIncasariTotale()} RON");
                Console.WriteLine($"Total reduceri: {casa.GetReduceriAcordate()} RON");

                Console.WriteLine("\nNumar bilete pe categorii:");
                Console.WriteLine($"Studenti: {casa.GetNumarBiletePerTip<BiletStudent>()}");
                Console.WriteLine($"VIP: {casa.GetNumarBiletePerTip<BiletVIP>()}");
                Console.WriteLine($"Seniori: {casa.GetNumarBiletePerTip<BiletSenior>()}");

                var celMaiScump = casa.GetBiletulCelMaiScump();
                if (celMaiScump != null)
                {
                    Console.WriteLine($"\nCel mai scump bilet: {celMaiScump.CalculeazaPretFinal()} RON " +
                                      $"(Film: {celMaiScump.NumeFilm}, Tip bilet: {celMaiScump.GetType().Name})");
                }

                Console.WriteLine("\nValidare varsta senior: ");
                Bilet testSenior = new BiletSenior(75, "Titanic", 2, TipFilm.Drama, dataFilm, ion, 100, 25);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Eroare: {ex.Message}.");
            }

        }
    }
}