using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    internal class Program
    {
        static void AnzeigeMenu()
        {
            Console.Clear();
            Console.WriteLine("Womit wollen Sie rechnen?");
            Console.WriteLine("1:(+)");
            Console.WriteLine("2:(-)");
            Console.WriteLine("3:(*)");
            Console.WriteLine("4:(/)");
            Console.WriteLine("0:(Programm beenden)");
        }
        static double BerechneErgebnis(int operation, double num1, double num2)
        {
            Console.Clear();
            switch (operation)
            {
                case 1: // Addition
                    Console.WriteLine($"Berechnung: {num1}+{num2}");
                    return num1 + num2;

                case 2: // Subtraktion
                    Console.WriteLine($"Berechnung: {num1}-{num2}");
                    return num1 - num2;

                case 3: // Multiplikation
                    Console.WriteLine($"Berechnung: {num1}*{num2}");
                    return num1 * num2;

                case 4: // Division
                    Console.WriteLine($"Berechnung: {num1}/{num2}");
                    if (num2 != 0)
                    {
                        return num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Division durch Null ist nicht erlaubt.");
                        return double.NaN; // NaN als Fehlerwert
                    }

                default:
                    return double.NaN; // Unbekannte Operation
            }
        }
        static void Main(string[] args)
        {
            string antwort = "j";
            while (antwort == "j")
            {
                AnzeigeMenu();

                string userInput = Console.ReadLine();
                int operation;

                if (int.TryParse(userInput, out operation))
                {

                    if (operation == 0)
                    {
                        return; //Programm beenden
                    }

                    else if (operation >= 1 && operation <= 4)
                    {
                        Console.WriteLine("Geben Sie die erste Zahl ein: ");
                        double num1;
                        if (double.TryParse(Console.ReadLine(), out num1))
                        {
                            Console.WriteLine("Geben Sie die zweite Zahl ein: ");
                            double num2;
                            if (double.TryParse(Console.ReadLine(), out num2))
                            {
                                double ergebnis = BerechneErgebnis(operation, num1, num2);
                                if (!double.IsNaN(ergebnis))
                                {
                                    Console.WriteLine($"Ergebnis = {ergebnis}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe für die zweite Zahl.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe für die erste Zahl.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("UNGÜLTIGE EINGABE!!! WÄHLEN SIE EINE DER VERFÜGBAREN OPTIONEN!!!");
                    }
                }
                else
                {
                    Console.WriteLine("UNGÜLTIGE EINGABE!!! WÄHLEN SIE EINE DER VERFÜGBAREN OPTIONEN!!!");
                }

                Console.WriteLine("\nWollen Sie neu starten?");
                Console.WriteLine("\t (j/n)");
                antwort = Console.ReadLine();


            }


        }
        
    }
}