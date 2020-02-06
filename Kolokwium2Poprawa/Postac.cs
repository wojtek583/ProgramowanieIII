using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2Poprawa
{
    [Flags]
    enum Statusy
    {
        Normalny =0,
        Trucizna =2,
        Ogluszenie =4,
        Spowolnienie =8,
        Szal = 16,
    }
    class Postac
    {
        public Postac()
        {
            HP = 10;
            //Statusy.Normalny;
        }

        public int HP { get; set; }
        public void Status()
        {
            //if (status =="Normalny")
           // {

           // }
        }
    }
}
