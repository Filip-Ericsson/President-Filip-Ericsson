using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace President
{
    class Program
    {
        static void Main(string[] args)
        {
            President president = new President("Arcturus Mengsk");

            while (true)
            {
                Console.WriteLine("Hello and welcome to President");
                Console.WriteLine("Press 1 to Present the Presidents values");
                Console.WriteLine("Press 2 to Pass Leglislation");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    president.Present();
                }
                else if (input == "2")
                {
                    Console.WriteLine("How much to put in enviroment, 0-100");

                    int.TryParse(Console.ReadLine(),out int e);
                    Console.WriteLine("How much to put in defence, 0-100");
                    int.TryParse(Console.ReadLine(), out int d);
                    Console.WriteLine("How much to put in healthcare, 0-100");
                    int.TryParse(Console.ReadLine(), out int h);
                    Console.WriteLine("Please, give some money, 0-100");
                    int.TryParse(Console.ReadLine(), out int bribe);



                    if (president.PassLegislation(e, d, h, bribe) == true)
                    {
                        Console.WriteLine("The law passed!");
                    }
                    else
                    {
                        Console.WriteLine("The President rejects your leglislation");
                    }



                }

                Console.ReadLine();
            }
        }
    }
}
