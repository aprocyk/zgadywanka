using System;
using System.Collections.Generic;

namespace LogikaGry
{
    // logika jednej rozgrywki
    public partial class Gra
    {
        //public const string trafiono = "TRAFIONO";

        public enum Odp {ZaMalo = -1, Trafiono, ZaDuzo };
        public enum Stan { Trwa, Poddana, Odgadnieta };

        public Stan StanGry { get; private set; }

        private readonly int wylosowana;
        public readonly int zakresOd;
        public readonly int zakresDo;
        public int LicznikRuchow { get; private set; }

        //historia gry: propozycja, ocena, kiedy
        private List<Ruch> historia;
        public IReadOnlyList<Ruch> Historia => historia.AsReadOnly();

        public Gra(int a = 1, int b = 100)
        {
            if (a > b)
            {
                zakresOd = b;
                zakresDo = a;
            }
            else
            {
                zakresOd = a;
                zakresDo = b;
            }

            var generator = new Random();
            wylosowana = generator.Next(zakresOd, zakresDo + 1);
            StanGry = Stan.Trwa;
            historia = new List<Ruch>();
        }

        public Odp Ocena( int propozycja )
        {
            Gra.Odp odp;

            if (wylosowana == propozycja)
            {
                odp = Odp.Trafiono;
                StanGry = Stan.Odgadnieta;
            }
            else if (wylosowana < propozycja)
                odp = Odp.ZaDuzo;
            else
                odp = Odp.ZaMalo;

            //zapisz historię
            historia.Add(new Ruch(propozycja, odp));
            LicznikRuchow++;

            return odp;
        }

        public void Poddaj()
        {
            StanGry = Stan.Poddana;
        }

        public int? Wylosowana
        {
            get
            {
                if (!(StanGry == Stan.Trwa))
                    return wylosowana;
                else
                    return null;
            }            
        }

        public override string ToString()
        {
            return $"Wylosowana z zakresu: {zakresOd}..{zakresDo}";
        }
    }

}
