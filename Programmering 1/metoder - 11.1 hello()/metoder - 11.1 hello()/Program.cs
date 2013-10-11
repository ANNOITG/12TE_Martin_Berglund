using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoder___11._1_hello__
{
    class Program
    {
        static void Hello(string name)
        {
            Console.WriteLine("Hello " + name + " !!!"); // Här sker inmatningen med en ofärdig variabel (name) som användaren ska mata in.
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What's your name ?"); // En fråga programmeraren ställer till användaren.

            Hello(Console.ReadLine()); // Här skrivs namnet (name) in av användaren till "Hello(string name)". 

            Console.ReadKey();
        }

        
    }
}
