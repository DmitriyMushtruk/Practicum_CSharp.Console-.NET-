using System;
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
                Console.WriteLine("\n\t\t C: Liczba Armstronga");
                Console.WriteLine("\n\t\t D: Sumy podzielników podanych liczb");
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

                    if (mdCheckNumber(mdNumber)) Console.WriteLine($"\n\tPodana liczba {mdNumber} jest idealna!"); else Console.WriteLine($"\n\tPodana liczba {mdNumber} NIE jest idealna!");
                    Console.Write("\n\n\tNaciśnij dowolny klawisz . . . ");
                    Console.ReadKey();
                }

                if (mdWybranaFunkcjonalność.Key == ConsoleKey.B)
                {
                    Console.Write("\n\n\tWYBRANO: 'B' - Czy podane liczby są liczbami zaprzyjaźnionymi\n");

                    int mdPierwszaLiczba;
                    Console.Write("\n\tPodaj pierwszą liczbę: ");

                    while (!int.TryParse(Console.ReadLine(), out mdPierwszaLiczba))
                    {   
                        Console.WriteLine("\n\tERROR: w zapisie wystąpił niedozwolony znak!");
                        Console.Write("\n\tPodaj pierwszą liczbę ponownie: ");
                    }


                    Console.Write($"\n\t");

                    int mdSuma1 = mdSumaPodzielnikow(mdPierwszaLiczba);

                    Console.Write($"\n\tSuma podźielników: {mdSuma1};");
                    Console.Write("\n\t________________________");

                    int mdDrugaLiczba;
                    Console.Write("\n\n\tPodaj drugą liczbę: ");

                    while (!int.TryParse(Console.ReadLine(), out mdDrugaLiczba) || mdPierwszaLiczba == mdDrugaLiczba)
                    {   
                        Console.WriteLine("\n\tERROR: w zapisie wystąpił niedozwolony znak!");
                        Console.WriteLine("\n\tUWAZAJ: liczby nie mogą być równe!");
                        Console.Write("\n\tPodaj drugą liczbę ponownie: ");
                    }

                    Console.Write($"\n\t");

                    int mdSuma2 = mdSumaPodzielnikow(mdDrugaLiczba);

                    Console.Write($"\n\tSuma podźielników: {mdSuma2};");
                    Console.Write("\n\t________________________");

                    Console.Write("\n\n\tWYNNIK:");

                    if (mdSuma1 == mdSuma2)
                    {
                        Console.Write($"\n\n\tPoniewaź sumy podźielników są równe: ({mdSuma1} = {mdSuma2}),");
                        Console.Write($"\n\tliczby {mdPierwszaLiczba} i {mdDrugaLiczba} są liczbami zaprzyjaźnionymi!\n");
                    } else
                    {
                        Console.Write($"\n\n\tPoniewaź sumy podźielników NIE są równe: ({mdSuma1} != {mdSuma2}),");
                        Console.Write($"\n\tliczby {mdPierwszaLiczba} i {mdDrugaLiczba} NIE są liczbami zaprzyjaźnionymi!\n");
                    }
                }

                if (mdWybranaFunkcjonalność.Key == ConsoleKey.C)
                {
                    Console.Write("\n\n\tWYBRANO: 'C' - Czy podane liczba jest liczba Armstronga\n");

                    uint mdLiczbaArmstronga;
                    Console.Write("\n\tPodaj liczbę dla sprawdzania: ");

                    while (!uint.TryParse(Console.ReadLine(), out mdLiczbaArmstronga))
                    {
                        Console.WriteLine("\n\tERROR!!!");
                    }

                    if (IsArmstrongNumber(mdLiczbaArmstronga))
                    {
                        Console.WriteLine($"\n\tPodana liczba - '{mdLiczbaArmstronga}' JEST liczbą Armstronga!");
                    } else
                    {
                        Console.WriteLine($"\n\tPodana liczba - '{mdLiczbaArmstronga}' NIE JEST liczbą Armstronga!");
                    }

                }

                if (mdWybranaFunkcjonalność.Key == ConsoleKey.D)
                {
                    Console.Write("\n\n\tWYBRANO: 'D' - Sumy podzielników podanych liczb\n");

                    Console.Write("\n\n\tPodaj ilisc elementow:\t");

                    int iloscElementow = int.Parse(Console.ReadLine());

                    int[,] tablicaElementow = new int[iloscElementow, 2];

                    for (int i = 0; i < tablicaElementow.GetLength(0); i++)
                    {
                        for (int j = 0; j < tablicaElementow.GetLength(1); j++)
                        {
                            if (j == 0)
                            {
                                Console.Write($"\n\tPodaj element numer - {i + 1}:\t");

                                tablicaElementow[i, j] = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                tablicaElementow[i, j] = mdSumaPodzielnikow(tablicaElementow[i, j - 1]);
                            }
                        }
                    }

                    Console.Write("\n\tWYNIKI OBLICZEN: \n");
                    Console.Write("\n\t  Podana liczba\tSuma podielnikow");
                    Console.Write("\n\t  _____________\t________________");


                    for (int x = 0; x < tablicaElementow.GetLength(0); x++)
                    {
                        Console.Write("\n\n");
                        for (int y = 0; y < tablicaElementow.GetLength(1); y++)
                        {
                            Console.Write("\t\t" + tablicaElementow[x, y]);
                        }
                        Console.Write("\n\n");
                    }

                }

                bool IsArmstrongNumber(uint number)
                {
                    var digits = SplitNumber(number);
                    var sum = 0u;
                    var p = (uint)digits.Length;
                    foreach (var digit in digits)
                    {
                        sum += Power(digit, p);
                    }

                    return sum == number;
                }

                uint Power(uint x, uint y)
                {
                    return y == 0
                        ? 1
                        : x * Power(x, y - 1);
                }

                uint[] SplitNumber(uint n)
                {
                    var result = new uint[0];
                    int i = 0;
                    while (n > 0)
                    {
                        Array.Resize(ref result, i + 1);
                        result[i] = n % 10;
                        n = n / 10;
                        i++;
                    }

                    Array.Reverse(result);
                    return result;
                }

                static int mdSumaPodzielnikow(int num)
                {
                    int sum = 0;
                    Console.Write($"\tPodzielniki liczby {num}: ");
                    for (int a = 1; a <= num; a++)
                    {
                        if (num % a == 0) 
                        { sum += a;
                          Console.Write(" {0}", a); 
                        }
                        
                    }
                    Console.Write(";\n");
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
