using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proceduralnie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra za duzo za malo");
            #region losowanie
            //1. komputer losuje
            Random generator = new Random();
            int wylosowana = generator.Next(0, 101);
#if DEBUG == true
            //Console.WriteLine(wylosowana); //do usuniecia w 1.0
#endif
            Console.WriteLine("Wylosowalem liczbę, odgadnij ją!");
            #endregion
            int licznikruchow = 0;
            bool trafiono = false;
            do
            {
                #region propozycja
                //2. gracz podaje propozyjce

                Console.Write("Podaj twoją propozycję: ");
                string tekst = Console.ReadLine();
                //Console.WriteLine($"Podałeś tekst {tekst}");
                int podana;
                try
                {
                    podana = Convert.ToInt32(tekst);
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
                #endregion

                #region ocenakomputera
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
                #endregion
                licznikruchow++;
            }
            while (!trafiono);
            Console.WriteLine("Koniec gry");
            Console.WriteLine($"Statystyki: Wykonane ruchy {licznikruchow}");
        }
    }
}
