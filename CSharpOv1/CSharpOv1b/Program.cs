using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOv1b
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Dette er en simpel kalkulator");
                Console.WriteLine("Her kan du +/- 2 tall");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Du skriver inn to tall for så å velge hvilken");
                Console.WriteLine("utregning du vil gjennomføre ved å trykke +/-");
                Console.WriteLine("For å avslutte trykk Q");
                Console.WriteLine("--------------------------------------------");

                double x = 0, y = 0;

                ConsoleKeyInfo nfo;

                try
                {
                    Console.WriteLine("Tall 1: ");

                    x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Tall 2: ");

                    y = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Dine to tall er " + x + " og " + y + ".");
                    Console.WriteLine("Trykk + for å addere, - for å subtrahere mellom disse to tallenen");

                    nfo = Console.ReadKey();

                    Console.WriteLine("\n");
                    
                    switch (nfo.Key)
                    {
                        case ConsoleKey.Add:
                            Console.WriteLine("Addere: " + x + " + " + y + " = " + Kalkulator.add(x, y));
                            break;
                        case ConsoleKey.Subtract:
                            Console.WriteLine("Subtrahere: " + x + " - " + y + " = " + Kalkulator.sub(x, y));
                            break;
                        case ConsoleKey.OemPlus:
                            Console.WriteLine("Addere: " + x + " + " + y + " = " + Kalkulator.add(x, y));
                            break;
                        case ConsoleKey.OemMinus:
                            Console.WriteLine("Subtrahere: " + x + " - " + y + " = " + Kalkulator.sub(x, y));
                            break;
                        default:
                            Console.WriteLine("Error M8 - FS made dis");
                            break;
                    }
                    
                    Console.WriteLine("\nTrykk en tast for å fortsette.\n");
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Kun tall er gyldige, prøv igjen. \nTrykk en tast for å fortsette \n");
                }

            } while (Console.ReadKey().Key != ConsoleKey.Q);  
        }
    }
}
