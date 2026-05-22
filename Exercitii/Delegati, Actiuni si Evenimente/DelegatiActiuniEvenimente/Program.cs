using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegatiActiuniEvenimente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<string, string> notificator = NotificareService.NotificaPrinSMS;
            //// NotificareService.NotificareClient notificator = NotificareService.NotificaPrinSMS;
            //notificator += NotificareService.NotificaPrinEmail;
            //notificator += NotificareService.Log;
            //notificator += (numarComanda, mesaj) => Console.WriteLine($"[PUSH] {numarComanda} {mesaj}.");
            //Console.WriteLine("Invocarea delegatului multicast cu un mesaj de test:");
            //notificator("320", "Hey peste tot");
            //Console.WriteLine("\nInvocarea delegatului multicast cu un mesaj de test dupa eliminarea NotificaPrinSMS:");
            //notificator -= NotificareService.NotificaPrinSMS;
            //notificator("321", "Hey fara SMS");

            Produs p1 = new Produs();
            p1.Pret = 1500;
            p1.Cantitate = 2;
            p1.Nume = "Laptop";

            Produs p2 = new Produs();
            p2.Pret = 4300;
            p1.Cantitate = 1;
            p2.Nume = "Telefon";

            List<Produs> produse1 = new List<Produs>();
            produse1.Add(p1);
            Comanda c1 = new Comanda("1", "Daria", "dariapora@gmail.com", produse1);

            List<Produs> produse2 = new List<Produs>();
            produse2.Add(p2);
            Comanda c2 = new Comanda("2", "Matei", "matei32@gmail.com", produse2);

            List<Produs> produse3 = new List<Produs>();
            produse3.Add(p1);
            produse3.Add(p2);
            Comanda c3 = new Comanda("3", "Ana", "anaaremere@gmail.com", produse3);

            NotificareService.NotificareClient notificator = NotificareService.NotificaPrinSMS;

            Depozit depozitProduse = new Depozit();

            depozitProduse.ComandaLivrata += (sender, e) =>
            {
                Console.WriteLine($"Comanda cu numarul {e.Comanda.NumarComanda} a fost livrata.");
            };

            depozitProduse.ComandaSchimbatStare += (sender, e) =>
            {
                Console.WriteLine($"Schimbare de stare pentru {e.Comanda.NumarComanda}: {e.StareVeche} => {e.StareNoua}");
            };

            depozitProduse.InregistreazaComanda(c1, notificator);
            depozitProduse.InregistreazaComanda(c2, notificator);
            depozitProduse.InregistreazaComanda(c3, notificator);

            depozitProduse.AvanseazaStare("2");
            depozitProduse.AvanseazaStare("2");
            depozitProduse.AvanseazaStare("2");
            
        }
    }
}
