using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Womit wollen Sie rechnen?");
            Console.WriteLine("1:(+)");
            Console.WriteLine("2:(-)");
            Console.WriteLine("3:(*)");
            Console.WriteLine("4:(/)");
            Console.WriteLine("0:(Programm beenden)");

            while (true)
            {
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
                        Console.WriteLine("Geben Sie Ihre erste Zahl ein: ");
                        int num1 = int.Parse(Console.ReadLine()); //Eingabe der ersten Rechnungsnummer
                        Console.WriteLine("Geben Sie Ihre zweite Zahl ein: ");
                        int num2 = int.Parse(Console.ReadLine()); //Eingabe der zweiten Rechnungsnummer
                        
                        Console.Clear(); //macht sauber

                        switch (operation)
                        {
                            case 1: //Plusberechnung 
                                Console.WriteLine("Rechnung: {0}+{1}", num1, num2);//Rechnung
                                Console.WriteLine("Ergebnis = " + (num1 + num2)); //Ergebnis
                                break;

                            case 2: //Minusberechnung
                                Console.WriteLine("Rechnung: {0}-{1}", num1, num2);//Rechnung
                                Console.WriteLine("Ergebnis = " + (num1 - num2)); //Ergebnis
                                break;

                            case 3: //Malberechnung
                                Console.WriteLine("Rechnung: {0}*{1}", num1, num2);//Rechnung
                                Console.WriteLine("Ergebnis = " + (num1 * num2)); //Ergebnis
                                break;

                            case 4: //Geteiltberechnung
                                Console.WriteLine("Rechnung: {0}/{1}", num1, num2);//Rechnung
                                if (num2 != 0)
                                {
                                    Console.WriteLine("Ergebnis = " + ((double)num1 / num2)); //Ergebnis
                                }
                                else
                                {
                                    Console.WriteLine("Division durch Null ist nicht erlaubt.");
                                }
                                break;
                        }
                        
                    }
                    else
                    {   // Ausgabe wenn man eine falsche Eingabe getätigt hat
                        Console.WriteLine("Ungültige Eingabe. Wählen Sie eine der verfügbaren Optionen.");
                    }
                }
                else
                {   // Ausgabe wenn man eine ungültige Zahl eingegeben hat
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                }
            }



        }
    }
}
