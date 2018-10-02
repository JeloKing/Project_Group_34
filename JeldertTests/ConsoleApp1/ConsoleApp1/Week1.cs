//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Opdracht A
//            Console.WriteLine("Hello world!");
//            Console.ReadKey();
//            // Opracht B
//            string s1 = "Jeldert";
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
//            // Opracht C
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
//            // Opdracht D
//            Console.Clear();
//        Fout1:
//            Console.WriteLine("Kies je taal/Choose your language/Choisissez votre langue/Wähle deine Sprache/Elige tu idioma: Nederlands, English, Français, Deutsche, Español");
//            string Language = Console.ReadLine();

//            if (Language.ToLower() == "nederlands")
//            {
//            Fout2:
//                Console.WriteLine("Ben je een man of een vrouw?");
//                string gender = Console.ReadLine();

//                if (gender.ToLower() == "man")
//                {
//                    Console.WriteLine("Vul hier je lengte in");
//                    double Lengte = Convert.ToDouble(Console.ReadLine());
//                    double gewicht = ((Lengte - 100) * 9);
//                    Console.WriteLine("Je ideale gewicht is " + gewicht + " hectogram");
//                }
//                else if (gender.ToLower() == "vrouw")
//                {
//                    Console.WriteLine("Vul hier je lengte in");
//                    double Lengte = Convert.ToDouble(Console.ReadLine());
//                    Console.WriteLine("Vul hier je polsomtrek in");
//                    double Pols = Convert.ToDouble(Console.ReadLine());
//                    double gewicht = ((Lengte + 4 * Pols) / 2);
//                    Console.WriteLine("Je ideale gewicht is " + gewicht + " hectogram");
//                }

//                else
//                {
//                    Console.WriteLine("Invoer niet herkend");
//                    goto Fout2;
//                }
//            }

//            else if (Language.ToLower() == "english")
//            {
//            Fout2:
//                Console.WriteLine("Are you a man or a woman?");
//                string gender = Console.ReadLine();

//                if (gender.ToLower() == "man")
//                {
//                    Console.WriteLine("Enter your height here");
//                    double Lengte = Convert.ToDouble(Console.ReadLine());
//                    double gewicht = ((Lengte - 100) * 9);
//                    Console.WriteLine("Your ideal weight is " + gewicht + " hectogram");
//                }
//                else if (gender.ToLower() == "woman")
//                {
//                    Console.WriteLine("Enter your height here");
//                    double Lengte = Convert.ToDouble(Console.ReadLine());
//                    Console.WriteLine("Enter your wrist circumference here");
//                    double Pols = Convert.ToDouble(Console.ReadLine());
//                    double gewicht = ((Lengte + 4 * Pols) / 2);
//                    Console.WriteLine("Your ideal weight is " + gewicht + " hectogram");
//                }

//                else
//                {
//                    Console.WriteLine("Input not recognized");
//                    goto Fout2;
//                }
//            }

//            else if (Language.ToLower() == "français")
//            {
//            Fout2:
//                Console.WriteLine("êtes-vous un homme ou une femme?");
//                string gender = Console.ReadLine();

//                if (gender.ToLower() == "homme")
//                {
//                    Console.WriteLine("Entrez votre taille ici");
//                    double Lengte = Convert.ToDouble(Console.ReadLine());
//                    double gewicht = ((Lengte - 100) * 9);
//                    Console.WriteLine("Votre poids idéal est un " + gewicht + " hectogramme");
//                }
//                else if (gender.ToLower() == "femme")
//                {
//                    Console.WriteLine("Entrez votre taille ici");
//                    double Lengte = Convert.ToDouble(Console.ReadLine());
//                    Console.WriteLine("Entrez votre tour de poignet ici");
//                    double Pols = Convert.ToDouble(Console.ReadLine());
//                    double gewicht = ((Lengte + 4 * Pols) / 2);
//                    Console.WriteLine("Votre poids idéal est un " + gewicht + " hectogramme");
//                }

//                else
//                {
//                    Console.WriteLine("Entrée non reconnue");
//                    goto Fout2;
//                }
//            }

//            else if (Language.ToLower() == "deutsche")
//            {
//            Fout2:
//                Console.WriteLine("Bist Du ein Mann oder eine Frau?");
//                string gender = Console.ReadLine();

//                if (gender.ToLower() == "mann")
//                {
//                    Console.WriteLine("Gib deine Höhe hier ein");
//                    double Lengte = Convert.ToDouble(Console.ReadLine());
//                    double gewicht = ((Lengte - 100) * 9);
//                    Console.WriteLine("Dein Idealgewicht ist " + gewicht + " Hektogramm");
//                }
//                else if (gender.ToLower() == "frau")
//                {
//                    Console.WriteLine("Gib deine Höhe hier ein");
//                    double Lengte = Convert.ToDouble(Console.ReadLine());
//                    Console.WriteLine("Tragen Sie hier Ihren Handgelenkumfang ein");
//                    double Pols = Convert.ToDouble(Console.ReadLine());
//                    double gewicht = ((Lengte + 4 * Pols) / 2);
//                    Console.WriteLine("Dein Idealgewicht ist " + gewicht + " Hektogramm");
//                }

//                else
//                {
//                    Console.WriteLine("Eingabe nicht erkannt");
//                    goto Fout2;
//                }
//            }

//            else if (Language.ToLower() == "español")
//            {
//            Fout2:
//                Console.WriteLine("eres hombre o mujer?");
//                string gender = Console.ReadLine();

//                if (gender.ToLower() == "hombre")
//                {
//                    Console.WriteLine("Ingrese su altura aquí");
//                    double Lengte = Convert.ToDouble(Console.ReadLine());
//                    double gewicht = ((Lengte - 100) * 9);
//                    Console.WriteLine("Tu peso ideal es " + gewicht + " hectogram");
//                }
//                else if (gender.ToLower() == "mujer")
//                {
//                    Console.WriteLine("Ingrese su altura aquí");
//                    double Lengte = Convert.ToDouble(Console.ReadLine());
//                    Console.WriteLine("Ingrese su circunferencia de muñeca aquí");
//                    double Pols = Convert.ToDouble(Console.ReadLine());
//                    double gewicht = ((Lengte + 4 * Pols) / 2);
//                    Console.WriteLine("Tu peso ideal es " + gewicht + " hectogram");
//                }

//                else
//                {
//                    Console.WriteLine("Entrée non reconnue");
//                    goto Fout2;
//                }
//            }

//            else
//            {
//                Console.WriteLine("Taal niet herkend/Language not recognized/Langue non reconnue/Sprache nicht erkannt/Idioma no reconocido");
//                goto Fout1;
//            }
//            Console.ReadKey();
//        }
//    }
//}
