﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        { //string s1 = "Jeldert";
//            string variabele1 = "C"; //C is een letter
//            int nummer1 = 123; //123 is een geheel getal
//            double nummer2 = 1.5; //1.5 is een komma getal
//            Boolean status = false; //false is een boolean
//            int nummerconvert = Convert.ToInt32(nummer2);
//            int rest = nummer1 % nummerconvert;
//            Console.WriteLine("Hello " + s1);
//            Console.WriteLine(variabele1 + " " + nummer1);
//            Console.WriteLine(nummer2 + " " + status);
//            Console.WriteLine(rest);
//            Console.ReadKey();
//            Console.Clear();
//            Console.WriteLine("geef een temperatuur in Celsius");
//            int Temperatuur = Convert.ToInt32(Console.ReadLine());
//            double Fahrenheit = (Temperatuur * 1.8 + 32);
//            Console.SetCursorPosition(0, 1);
//            Console.WriteLine(Temperatuur + " Graden Celsius staat gelijk aan " + Fahrenheit + " graden Fahrenheit");
//            Console.ReadKey();
//            Console.Clear();
//            Console.WriteLine("geef een getal op in euro's");
//            double Euro = Convert.ToDouble(Console.ReadLine());
//            double Dollar = (Euro * 1.16);
//            Console.SetCursorPosition(0, 1);
//            Console.WriteLine(Euro + " Euro is " + Dollar + " USDollar");
//            Console.ReadKey();
//            Console.WriteLine("Kies je taal");
//        Start:
//            Console.WriteLine("Ben je een man of een vrouw?");
//            string gender = Console.ReadLine();

//            if (gender.ToLower() == "man")
//            {
//                Console.WriteLine("Vul hier je lengte in");
//                double Lengte = Convert.ToDouble(Console.ReadLine());
//                double gewicht = ((Lengte - 100) * 9);
//                Console.WriteLine("Je ideale gewicht is " + gewicht);
//            }
//            else if (gender.ToLower() == "vrouw")
//            {
//                Console.WriteLine("Vul hier je lengte in");
//                double Lengte = Convert.ToDouble(Console.ReadLine());
//                Console.WriteLine("Vul hier je polsomtrek in");
//                double Pols = Convert.ToDouble(Console.ReadLine());
//                double gewicht = ((Lengte + 4 * Pols) / 2);
//                Console.WriteLine("Je ideale gewicht is " + gewicht);
//            }

//            else
//            {
//                Console.WriteLine("Input niet herkend");
//                goto Start;
//            }
//            Console.ReadKey();
//        }
//    }
//}
