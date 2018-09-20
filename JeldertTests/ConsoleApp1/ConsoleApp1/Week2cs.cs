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
            for (; macht < 1024; macht * macht) ;
            {
                while (macht < 1024) ;
                {
                    Console.WriteLine("2 raised to the power: {0}", macht);
                }
            }
        }
    }
}