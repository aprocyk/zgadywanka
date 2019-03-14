using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolit
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
                int podana = Convert.ToInt32(tekst);
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
