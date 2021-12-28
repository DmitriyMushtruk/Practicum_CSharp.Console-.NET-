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
                Console.WriteLine("\n\t\t X: Wyjście z programu");

                //Podpowiedz dla uzytkownika
                Console.Write("\n\n\tNaciśnieciem odpowiedniego klawisza wybierź jedną z oferowanych funkcjalnosci: ");

                //Wczytanie kodu naciśnietego klawisza
                mdWybranaFunkcjonalność = Console.ReadKey();

                if (mdWybranaFunkcjonalność.Key == ConsoleKey.A)
                {   //potwierdzenie wybrania funkcjalnosci
                    Console.Write("\n\n\tWYBRANO: 'E' - Czy podana liczba jest liczbą doskonałą\n");

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
                    Console.ReadKey();
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
