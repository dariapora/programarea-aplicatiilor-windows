using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatiActiuniEvenimente
{
    public static class NotificareService
    {

        public delegate void NotificareClient(string numarComanda, string mesaj);               
        public static void NotificaPrinEmail(string numarComanda, string mesaj)
        {
            Console.WriteLine($"[EMAIL] {numarComanda} {mesaj}!");
        }
        public static void NotificaPrinSMS(string numarComanda, string mesaj)
        {
            Console.WriteLine($"[SMS] {numarComanda} {mesaj}!");
        }
        public static void Log(string numarComanda, string mesaj)
        {
            Console.WriteLine($"[LOG] {numarComanda} {mesaj}!");
        }
    }
}
