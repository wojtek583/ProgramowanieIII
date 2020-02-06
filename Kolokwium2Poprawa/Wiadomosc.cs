using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium2Poprawa
{
    class Wiadomosc
    {
        public Wiadomosc(string tresc, string autor, DateTime data)
        {
            Tresc = tresc;
            Autor = autor;
            Data = data;
        }

        public string Tresc { get; set; }
        public string Autor { get; set; }
        public DateTime Data { get; set; }
        public void Deconstructor(out string tresc, out string autor, out DateTime data)
        {
            tresc = Tresc;
            autor = Autor;
            data = Data;
        }
        public void Deconstructor(out int znaki, out DateTime data)
        {

            data = Data;
            znaki = Tresc.Length;
            //data = DateTime.Now.AddDays(-Data);
            
        }
    }
}
