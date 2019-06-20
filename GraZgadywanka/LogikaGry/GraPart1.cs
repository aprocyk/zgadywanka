using System;
using System.Collections.Generic;
using System.Text;

namespace LogikaGry
{
    public partial class Gra
    {
        public class Ruch
        {
            public readonly int propozycja;
            public readonly Gra.Odp odp;
            public readonly DateTime kiedy;
            public static int Licznik { get; private set; } = 0;

            public Ruch(int propozycja, Gra.Odp odp)
            {
                this.propozycja = propozycja;
                this.odp = odp;
                kiedy = DateTime.Now;
                Licznik++;
            }
        }

    }
}
