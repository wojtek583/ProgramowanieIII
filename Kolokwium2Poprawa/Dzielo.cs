using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2Poprawa
{
    abstract class Dzielo
    {
        protected Dzielo(string nrKarty, string tytul)
        {
            NrKarty = nrKarty;
            Tytul = tytul;
        }
        public virtual void Opis()
        {
            Console.WriteLine();
        }
        public string NrKarty { get; set; }
        public string Tytul { get; set; }
    }
}
