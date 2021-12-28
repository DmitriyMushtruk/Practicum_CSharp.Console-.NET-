﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_CSharp.Console_.NET_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Zadania dla samodzielnego rozwiązania , Author: Mushtruk Dmytro";

            ConsoleKeyInfo mdWybranaFunkcjonalność;

            do
            {
                Console.WriteLine("\n\t\t MENU \n");
                Console.WriteLine("\n\t\t A: Liczba doskonała");
                Console.WriteLine("\n\t\t B: Liczby zaprzyjaźnione");
                Console.WriteLine("\n\t\t X: Wyjście z programu");

                //Podpowiedz dla uzytkownika
                Console.Write("\n\n\tNaciśnieciem odpowiedniego klawisza wybierź jedną z oferowanych funkcjalnosci: ");

                //Wczytanie kodu naciśnietego klawisza
                mdWybranaFunkcjonalność = Console.ReadKey();

                if (mdWybranaFunkcjonalność.Key == ConsoleKey.A)
                {   //potwierdzenie wybrania funkcjalnosci
                    Console.Write("\n\n\tWYBRANO: 'A' - Czy podana liczba jest liczbą doskonałą\n");

                    int mdNumber = 0;

                    Console.Write($"\n\tPodaj liczbę dla sprawdzania: ");
                    while (!int.TryParse(Console.ReadLine(), out mdNumber) || (mdNumber < 0))
                    {
                        Console.WriteLine("\n\tERROR: niedozwolony znak! Pamietaj ze liczba nusi byc wiencej zera!");
                        Console.Write("\n\tPodaj ponownie liczbę dla sprawdzania: ");
                    }

                    //Console.WriteLine("\n\tPodaj liczbę dla sprawdzania: ");
                    //mdNumber = Convert.ToInt32(Console.ReadLine());

                    if (mdCheckNumber(mdNumber)) Console.WriteLine($"\n\tPodana liczba {mdNumber} jest idealna!"); else Console.WriteLine($"\n\tPodana liczba {mdNumber} NIE jest idealna!");
                    Console.Write("\n\n\tNaciśnij dowolny klawisz . . . ");
                    Console.ReadKey();
                }

                if (mdWybranaFunkcjonalność.Key == ConsoleKey.B)
                {
                    Console.Write("\n\n\tWYBRANO: 'B' - Czy podane liczby są liczbami zaprzyjaźnionymi\n");

                    Console.Write("\n\tPodaj pierwszą liczbę: ");
                    int mdPierwszaLiczba = int.Parse(Console.ReadLine());

                    Console.Write($"\n\tPodźielniki liczby '{mdPierwszaLiczba}':");

                    int mdSuma1 = mdSumaPodzielnikow(mdPierwszaLiczba);

                    Console.Write($"\n\n\tSuma podźielników: {mdSuma1};");
                    Console.Write("\n\t________________________");

                    Console.Write("\n\n\tPodaj drugą liczbę: ");
                    int mdDrugaLiczba = int.Parse(Console.ReadLine());

                    Console.Write($"\n\tPodźielniki liczby '{mdDrugaLiczba}':");

                    int mdSuma2 = mdSumaPodzielnikow(mdDrugaLiczba);

                    Console.Write($"\n\n\tSuma podźielników: {mdSuma2};");
                    Console.Write("\n\t________________________");

                    Console.Write("\n\n\tWYNNIK:");

                    if (mdSuma1 == mdSuma2)
                    {
                        Console.Write($"\n\n\tPoniewaź sumy podźielników są równe: ({mdSuma1} = {mdSuma2}), więc");
                        Console.Write($"\n\tliczby {mdPierwszaLiczba} i {mdDrugaLiczba} są liczbami zaprzyjaźnionymi!\n");
                    } else
                    {
                        Console.Write($"\n\n\tPoniewaź sumy podźielników NIE są równe: ({mdSuma1} != {mdSuma2}), więc");
                        Console.Write($"\n\tliczby {mdPierwszaLiczba} i {mdDrugaLiczba} NIE są liczbami zaprzyjaźnionymi!\n");
                    }

                }

                static int mdSumaPodzielnikow(int num)
                {
                    int sum = 0;
                    for (int a = 1; a <= num; a++)
                    {
                        if (num % a == 0) 
                        { sum += a;
                          Console.Write(" {0}", a); 
                        }
                        
                    }

                    Console.Write(";");
                    return sum;
                }


                static bool mdCheckNumber(int num)
                {
                    int sum = 1;
                    for (int i = 2; i < num / 2 + 1; i++) if (num % i == 0) sum += i;
                    return (sum == num);
                }

            } while (mdWybranaFunkcjonalność.Key != ConsoleKey.X);

                Console.WriteLine("\n\tAuthor: Mushtruk Dmytro");
                Console.WriteLine($"\n\tData: {DateTime.Now}");
                Console.Write("\n\tAby wyjść, naciśnij dowolny klawisz. . .");
                Console.ReadKey();

        }
    }
}
