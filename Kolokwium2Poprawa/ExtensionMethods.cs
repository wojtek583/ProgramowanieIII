using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2Poprawa
{
    public static class ExtensionMethods
    {
        public static decimal Netto(this decimal number, int vat)
        {
            return (vat/100)*number;
        }
    }
}
