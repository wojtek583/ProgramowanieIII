using System;
using System.Collections.Generic;
using System.Text;

namespace Laborki10Programowanie
{
    [Flags]
     public   enum TypOsoby
        {
        //zawsze musi byc zabezpieczone "0" np : Brak=0;

            Brak=0,
            Dziecko=1, //[0001]
            Mlodzierz=2, //[0010]
            Dorosly=4, //[0100]
            Starszy=8 //[1000]
        }
    [Flags]
        enum Zainteresowania
        {
            Elektronika,
            Motoryzacja,
            Gaming,
            Edukacja
        }
    
}
