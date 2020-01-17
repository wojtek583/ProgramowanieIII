using System;

namespace Laborki10Programowanie
{
    class Program
    {
        static double ObliczCeneBiletu(object pasazer)
        {
            #region SwitchPasazer
            switch (pasazer)
            {
                case Dziecko d:
                    Console.WriteLine($"To jest dziecko ma zniszke {d.Znizka}");
                    break;
                case OsobaStarsza os when os.ZwolnienieZOplaty:
                    Console.WriteLine("to jest osoba starsza" + "ma darmowe przejazdy");
                    break;
                case OsobaStarsza _:
                    Console.WriteLine("to jest osoba starsza");
                    break;
                case Rencista r when r.ZwolnienieZZaplaty:
                    if (r.WaznoscRenty > DateTime.Now)
                    {
                        Console.WriteLine("Rencista zwolniony");
                    }
                    else
                    {
                        Console.WriteLine("Musi zaplacic");
                    }
                    break;

                case null:
                    Console.WriteLine("Nie wiadomo kto to jest");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;

            }
            return 0;
#endregion
            #region poprzedniawersja
            //if (pasazer is Dziecko dziecko)
            //{
            //   // var dziecko = (Dziecko)pasazer;

            //    Console.WriteLine($"to jest dziecko, ma zniżke {dziecko.Znizka}");
            //}
            //else if (pasazer is OsobaStarsza oStarsza)
            //{
            //    Console.WriteLine("To jest osoba starsza");
            //    if (oStarsza.ZwolnienieZOplaty)
            //    {
            //        Console.WriteLine("ma darmowy przejazd");
            //    }
            //}
            //return 0;
            #endregion

        }
        static void Main(string[] args)
        {
            #region DoPasazera
            /*
            var pasazer = new ZwyklyPasazer();
            var dziecko = new Dziecko() { Znizka = 0.5 };
            var emeryt = new OsobaStarsza() { ZwolnienieZOplaty = true };
            var rencista = new Rencista() { ZwolnienieZZaplaty = true, WaznoscRenty = new DateTime(2020, 1, 10) };
            var rencista1 = new Rencista() { ZwolnienieZZaplaty = true, WaznoscRenty = new DateTime(2020, 8, 10) };

            ObliczCeneBiletu(pasazer);
            ObliczCeneBiletu(dziecko);
            ObliczCeneBiletu(emeryt);
            ObliczCeneBiletu(rencista);
            ObliczCeneBiletu(rencista1);
            ObliczCeneBiletu("pasazer");
            ObliczCeneBiletu(null);
            Console.ReadKey();
            */
            #endregion
            var osoba = new OsobaStarsza()
            {
                NrLegitymacji = "1234567890",
                ZwolnienieZOplaty = true,
                DataUrodzenia = DateTime.Now.AddYears(-70),
                AdresZdjecia = "./images/photos/1234567890.jpg"
            };

            //Console.WriteLine(osoba.ZwrocWszystkieDane());
            //var temp = osoba.ZwrocWszystkieDane();

            //Console.WriteLine($"{temp.nrlegitki} {temp.zwolnieniezoplaty}");

            //(_, bool zwolnienie, DateTime data, string fotografia) = osoba.ZwrocWszystkieDane();


            var (nrLegitymacji, zwolnienie, urodziny, zdjecie) = osoba;
            var osoba1 = new Dziecko()
            {
                Znizka = 12,
                DataUrodzenia = DateTime.Now.AddYears(-18),
            };

            var (dataurodzenia,klasa) = osoba1;
            Console.WriteLine(klasa+ "  "+dataurodzenia.ToShortDateString());


        }
    }
}
