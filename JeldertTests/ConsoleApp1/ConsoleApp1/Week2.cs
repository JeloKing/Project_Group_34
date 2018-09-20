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
            int macht = 2;
            for (; macht < 1025; macht = macht * 2)
            {
                Console.WriteLine("2 raised to the power: {0}", macht);
                
            }
            Console.ReadKey();
            int getal = 2;
            while (getal < 1025)
            {
                Console.WriteLine("2 raised to the power: {0}", getal);
                getal = getal * 2;
            }
            Console.ReadKey();
            int number = 2;
            do
            {
                Console.WriteLine("2 raised to the power: {0}", number);
                number = number * 2;
            }
            while (number < 1025);
            Console.ReadKey();
        }
    }
}