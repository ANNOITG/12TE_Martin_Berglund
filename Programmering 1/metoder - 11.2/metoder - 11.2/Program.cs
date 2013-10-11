using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoder___11._2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Mata in två olika rader med text");

            string inm1 = Console.ReadLine(); // Inmatningarna skrivs av användaren i (inm 1 & 2)
            string inm2 = Console.ReadLine();

            Console.WriteLine(galosh(inm1, inm2));
            
            Console.ReadKey();
        }

        public static string galosh(string inm1, string inm2)
        {
            return inm1 + inm2; // Inmatingarna "skickas" tillbaka, nu på samma rad
        }
    }
}

// Övning 11.3 är identisk med den här, men i den används int istället för string
