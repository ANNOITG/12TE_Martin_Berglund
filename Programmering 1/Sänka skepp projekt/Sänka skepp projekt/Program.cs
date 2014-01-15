using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sänka_skepp_projekt
{
    class Program
    {
        static void Valkommen()
        {
            Console.WriteLine("Välkommen till sänka skepp"); // Välkommst meddelande (som jag inte vet varför det inte visas i början)
        }


        public static string[,] spelplan = new string[10, 10];
        public static string[,] MakePlan()
        {
            

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    spelplan[x, y] = "#"; // Alla kordinater för tomrum (inkl. gömda skepp)
                }
            }

            spelplan[0, 0] = "*"; // Alla kordinaterna för skeppen

            spelplan[2, 5] = "*";

            spelplan[7, 6] = "*";

            spelplan[3, 0] = "*";

            spelplan[9, 9] = "*";

            spelplan[1, 8] = "*";

            spelplan[6, 6] = "*";


            return spelplan;

        }

        public static void DrawPlan() // Här är själva spelplanen "programmerad"
        {
            for (int y = 0; y < 10; y++)
            {
                Console.WriteLine("---------------------");
                for (int x = 0; x < 10; x++)
                {
                    Console.Write("|");
                    if (spelplan[x, y] != "*")
                    {
                        Console.Write(spelplan[x, y]);
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine("|");
            }
        }


        public static bool skjut(int x, int y)
        {
            if (spelplan[x, y] == "O" || spelplan[x, y] == "X")
            {
                //Do stuff
            }
            else if (spelplan[x, y] == "*")
            {
                spelplan[x, y] = "X";
                Console.WriteLine("HIT!");
            }
            else
            {
                spelplan[x, y] = "O";
                Console.WriteLine("MISS");

            }

            int left = 0;

            foreach (string s in spelplan)
            {
                if (s == "*")
                    left++;
            }

            if (left == 0)
                return true;
            else
                return false;
        } // Funktioner för användaren

        static void Main(string[] args)
        {

            MakePlan();



            while (true)
            {
                DrawPlan();



                string inm1; // Användarens inmatningar
                string inm2;

                int x, y;

                while (true)
                {
                    try
                    {
                        //användvbarhet
                        inm1 = Console.ReadLine();
                        x = int.Parse(inm1);
                        break;
                    }

                    catch
                    {
                        Console.WriteLine("Endast heltal");
                    }

                }

                while (true)
                {
                    try
                    {
                        inm2 = Console.ReadLine();
                        y = int.Parse(inm2);
                        break;
                    }

                    catch
                    {
                        Console.WriteLine("Endast heltal");
                    }
                }

                if (skjut(x, y))
                {
                    Environment.Exit(0);
                }
            }

            Console.ReadKey();
        }
    }
}
