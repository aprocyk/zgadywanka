using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolit
{
    class Program
    {
        static int wylosowana = 0;
        /// <summary>
        /// Losuje liczbę całkowitą z podanego zakresu, włącznie.
        /// </summary>
        /// <param name="min">wartość od której losujemy, włącznie</param>
        /// <param name="max">wartośc do której losujemy, wyłącznie</param>
        static void Losuj(int min=0, int max=101) {
            if (min > max) {
                throw new ArgumentOutOfRangeException("Hold up nigga, min jest wieksze niz max");
            }
            Random generator = new Random();
            int wylosowana = generator.Next(min, max);

            Console.WriteLine(wylosowana); //do usuniecia w 1.0

            Console.WriteLine("Wylosowalem liczbę, odgadnij ją!");

        }
        static int WczytajLiczbe(string prompt ="Podaj twoją propozycję: " )
        {
            Console.Write(prompt);
            string tekst = Console.ReadLine();
            return (Convert.ToInt32(tekst));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Gra za duzo za malo");
            
            //1. komputer losuje
            Losuj(100, 1);
            int licznikruchow = 0;
            bool trafiono = false;
            do
            {
                
                //2. gracz podaje propozyjce


                int podana;
                try
                {
                    podana = WczytajLiczbe("Podaj wymyslona wartosc: ");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie podales liczby, sprobuj jeszcze raz");
                    licznikruchow++;
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Podana liczba wykracza poza zakres od {int.MinValue} do {int.MaxValue}");
                    licznikruchow++;
                    continue;
                }
                

                
                //3. kumpoter ocenia
                if (wylosowana < podana)
                {
                    Console.WriteLine("Za dużo :C");
                }
                else if (wylosowana > podana)
                {
                    Console.WriteLine("Za mało :C");
                }
                else
                {
                    Console.WriteLine("Trafiłeś!");
                    trafiono = true;
                }
                
                licznikruchow++;
            }
            while (!trafiono);
            Console.WriteLine("Koniec gry");
            Console.WriteLine($"Statystyki: Wykonane ruchy {licznikruchow}");
        }
    }
}