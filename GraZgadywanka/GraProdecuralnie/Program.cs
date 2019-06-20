using System;
using System.Diagnostics;

namespace GraProceduralnie
{
    class Program
    {
        static Stopwatch stoper = new Stopwatch();

        static int wylosowana = 0;

        /// <summary>
        /// Losuje liczbę całkowitą z podanego zakresu, włącznie.
        /// </summary>
        /// <param name="min">wartość od której losujemy, włącznie</param>
        /// <param name="max">wartość do której losujemy, włącznie</param>
        /// <returns>wylosowana wartość z podanego zakresu</returns>
        /// <exception cref="ArgumentOutOfRangeException">jeśli min > max</exception>
        static int Losuj(int min = 0, int max = 100)
        {
            if (min > max)
                throw new ArgumentOutOfRangeException("min jest wieksze niż max");

            var generator = new Random();
            return generator.Next(min, max + 1);

#if DEBUG
            Console.WriteLine(wylosowana); //do usunięcia w wersji finalnej
#endif
            Console.WriteLine("Wylosowałem liczbę, odgadnij ją!");
        }

        static int WczytajLiczbe(string prompt = "Podaj Twoją propozycję: ")
        {
            Console.Write(prompt);
            string tekst = Console.ReadLine();
            return Convert.ToInt32(tekst);
        }

        static string Ocena(int prop)
        {
            if (wylosowana < prop)
            {
                return "Za dużo";
            }
            else if (wylosowana > prop)
            {
                return "Za mało";
            }
            else
            {
                return "TRAFIONO!";
            }
        }


        static void Main(string[] args)
        {
            stoper.Start();
            Console.WriteLine("Gra za dużo za mało");

            //1. komputer losuje
            Console.WriteLine("Muszę wylosować liczbę z podanego przez ciebie zakresu!");
            Console.WriteLine("Podaj dolny i górny zakres. Pamiętaj, że dolny < górny");
            int min = WczytajLiczbe("Podaj dolny zakres: ");
            int max = WczytajLiczbe("Podaj górny zakres: ");
            wylosowana = Losuj(min, max);

            int licznikRuchow = 0;
            do
            {
                #region propozycja gracza
                //2. gracz podaje propozycję
                int propozycja;
                try
                {
                    propozycja = WczytajLiczbe("Podaj wymysloną wartość: ");
                }
                catch (FormatException)
                {
                    Console.WriteLine("nie podałeś liczby, spróbuj jeszcze raz");
                    licznikRuchow++;
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"podana liczba wykracza poza zakres od {int.MinValue} do {int.MaxValue}, spróbuj jeszcze raz");
                    licznikRuchow++;
                    continue;
                }
                #endregion

                //3. komputer ocenia
                string wynik = Ocena(propozycja);
                Console.WriteLine(wynik);
                if (wynik == "TRAFIONO!")
                    break;

                licznikRuchow++;
            }
            while (true);

            stoper.Stop();
            Console.WriteLine($"Liczba ruchów = {licznikRuchow}, czas gry = {stoper.Elapsed}");
            Console.WriteLine("Koniec gry");
        }
    }
}
