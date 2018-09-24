//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        // Opdracht B
//        public static int Fibonacci(int n)
//        {
//            int a = 0;
//            int b = 1;
//            for (int i = 0; i < n; i++)
//            {
//                int temp = a;
//                a = b;
//                b = temp + b;
//            }
//            return a;

//        }
//        static void Main(string[] args)
//        {
//            ////Opdracht A
//            //int macht = 2;
//            //for (; macht < 1025; macht = macht * 2)
//            //{
//            //    Console.WriteLine("2 raised to the power: {0}", macht);

//            //}
//            //Console.ReadKey();
//            //int getal = 2;
//            //while (getal < 1025)
//            //{
//            //    Console.WriteLine("2 raised to the power: {0}", getal);
//            //    getal = getal * 2;
//            //}
//            //Console.ReadKey();
//            //int number = 2;
//            //do
//            //{
//            //    Console.WriteLine("2 raised to the power: {0}", number);
//            //    number = number * 2;
//            //}
//            //while (number < 1025);

//            //Console.ReadKey();
//            //Console.Clear();

//            //Double counter = 0,
//            //    numbers,
//            //    largest = int.MinValue;

//            //while (++counter <= 5)
//            //{
//            //    Console.WriteLine("voer getal in", counter);
//            //    numbers = Convert.ToDouble(Console.ReadLine());

//            //    if (number > largest)
//            //        largest = number;
//            //}

//            //Console.WriteLine("Het hoogste getal is {0}", largest);
//            //Console.ReadKey();
//            //Console.Clear();
//            //// Opdracht B
//            //for (int i = 0; i < 15; i++)
//            //{
//            //    Console.WriteLine(Fibonacci(i));
//            //}
//            //Console.ReadKey();
//            //Console.Clear();

//            //Console.WriteLine("Zet een bedrag in tussen de €5,- en de €100,-");

//            //Console.Clear();
//            //Opdracht C
//            for (int x = 0; x < 10; x++)
//            {
//                for (int y = 0; y < 10; y++)
//                {
//                    if ((x + y) % 2 == 0)
//                    {
//                        if ((x * y) <= 25)
//                            Console.Write("-");
//                        else
//                            break;
//                    }
//                    else
//                        Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//            Console.ReadKey();
//            // doordat de (x+y) % 2 toggled tussen 1 en 0 pakt hij het als aan (_) en uit (*),
//            // bij twee keer achter elkaar breekt hij deze en zet er een onderbreking in
//        }
//    }
//}