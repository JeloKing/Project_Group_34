using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opdracht A
            Console.WriteLine("Geef hoeveelheid getallen voor invoer op:");
            int counter1 = Convert.ToInt32(Console.ReadLine());
            int counting1 = 1;
            Double[] userinput1 = new double[counter1];
            for (int amount = 0; amount < userinput1.Length; amount++)
            {
                Console.WriteLine("voer getal " + counting1++ + " in");
                userinput1[amount] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Het gemiddelde is ");
            Console.WriteLine(userinput1.Average());
            Console.ReadKey();

            Console.WriteLine();
            string[] userinput2 = new string[10];
            for (int amount = 0; amount < userinput2.Length; amount++)
            {
                Console.WriteLine("voer naam " + amount + 1 + " in");
                userinput2[amount] = Console.ReadLine();
                if (userinput2[amount] == "stop")
                {
                    amount = 10;
                    userinput2[amount] = null;
                    break;
                }
            }
        }
    }
}