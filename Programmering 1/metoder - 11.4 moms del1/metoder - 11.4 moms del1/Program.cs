using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoder___11_4_moms_del1
{
    class Program
    {
        static void Main(int[] args)
        {
            Console.WriteLine("Skriv en summa för att få det inkl. moms");

            int inm = int.Parse(Console.ReadLine());

            Console.ReadKey();

        }

        static double momsa(double pris)
        {
            pris = pris * 1.25;

            return pris;

        }
    }
}
