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
            //Här skapas en ny instans av classen President
            President president = new President("Arcturus Mengsk");

            while (true)
            {
                Console.WriteLine("Hello and welcome to President");
                Console.WriteLine("Press 1 to Present the Presidents values");
                Console.WriteLine("Press 2 to Pass Leglislation");
                string input = Console.ReadLine();

                //Spelaren får välja att se hur presidenten står i sina områden, "enviroment" "defence" "healthcare" eller fårslå en ny lag
                if (input == "1")
                {
                    president.Present(); //presidentens "stats"
                }
                else if (input == "2") // fårslå en ny lag
                {
                    Console.WriteLine("How much to put in enviroment, 0-100");

                    int.TryParse(Console.ReadLine(),out int e); //Omvandlar string till int
                    Console.WriteLine("How much to put in defence, 0-100");
                    int.TryParse(Console.ReadLine(), out int d);
                    Console.WriteLine("How much to put in healthcare, 0-100");
                    int.TryParse(Console.ReadLine(), out int h);
                    Console.WriteLine("Please, give some money, 0-100");
                    int.TryParse(Console.ReadLine(), out int bribe);



                    if (president.PassLegislation(e, d, h, bribe) == true) //metoden i klassen president som hämtar fyra olika värden, int.
                    {                                                       //
                        Console.WriteLine("The law passed!");
                    }
                    else // om inte sann, blir lagen om spelaren ville ta igenom, inte sann.
                    {
                        Console.WriteLine("The President rejects your leglislation");
                    }



                }

                Console.ReadLine();
            }
        }
    }
}
