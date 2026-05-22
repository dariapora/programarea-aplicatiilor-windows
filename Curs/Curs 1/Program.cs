using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diferente
{
    internal class Program
    {
        // static void get_media(int[] fv, int n, out double fma)
        // {
        //    fma = 0;
        //    for (int i = 0; i < n; i++) fma += fv[i];
        //    fma /= n;
        //}
        static void Main(string[] args)
        {
            List<int> v = new List<int>();
            string ns;
            Console.Write("Dati element: ");
            while ((ns = Console.ReadLine()) != null)
            {
                v.Add(int.Parse(ns));
                Console.Write("Dati element: ");
            }
            // int numarElemente;
            // int[] v = new int[100];
            // Console.WriteLine("Dati nr elementelor: ");
            // numarElemente = int.Parse(Console.ReadLine());
            // for (int i = 0; i < numarElemente; i++)
            // {
            //    Console.Write("Introdu elementul {0}: ", i);
            //    v[i] = int.Parse(Console.ReadLine());
            // }
            // Console.Write("Elementele vectorului: \n");
            // for (int i = 0; i < numarElemente; i++)
            // {
            //     Console.Write("Elementul {0} este {1}\n", i, v[i]);
            // }
        }
    }
}