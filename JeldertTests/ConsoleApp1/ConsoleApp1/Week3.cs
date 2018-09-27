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
            Double counter = 0,
                            numbers,
                            largest = int.MinValue;

            while (++counter <= 4)
            {
                Console.WriteLine("voer getal in", counter);
                numbers = Convert.ToDouble(Console.ReadLine());

                if (numbers > largest)
                    largest = numbers;
            }
            Console.ReadKey();
        }
    }
}