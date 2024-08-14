using System;

namespace Hotelangebotssoftware
{
    struct ZimmerPreis
    {
        public string Kategorie;
        public int MaxAnzahlErwachsene;
        public int MaxAnzahlKinder;
    }

    internal class Program : Unterkunft
    {
        static void Main(string[] args)
        {
            int Unterkunftsart = 0;
            int AnzahlGaeste = 0;
            int AnzahlKinder = 0;
            int Aufenthaltsdauer = 0;
            double RabattKinder = 25.0;
            int ZimmerKategorie = 0;
            string Antwort = "";

            ZimmerPreis[] ZimmerPreis = new ZimmerPreis[3];
            ZimmerPreis[0].Kategorie = Convert.ToString(Kategorie.Standard);
            ZimmerPreis[0].MaxAnzahlErwachsene = 2;
            ZimmerPreis[0].MaxAnzahlKinder = 2;
            ZimmerPreis[1].Kategorie = Convert.ToString(Kategorie.Komfort);
            ZimmerPreis[1].MaxAnzahlErwachsene = 4;
            ZimmerPreis[1].MaxAnzahlKinder = 2;
            ZimmerPreis[2].Kategorie = Convert.ToString(Kategorie.Suite);
            ZimmerPreis[2].MaxAnzahlErwachsene = 6;
            ZimmerPreis[2].MaxAnzahlKinder = 4;

            Zimmer Zimmer = new Zimmer();

            Zimmer ZimmerStandard = new Zimmer(Kategorie.Standard, 20d, 1, 50d, 2, 19);
            Zimmer ZimmerKomfort = new Zimmer(Kategorie.Komfort, 20d, 2, 80d, 3, 19);
            Zimmer ZimmerSuite = new Zimmer(Kategorie.Suite, 20d, 4, 120d, 6, 19);


            Unterkunftsart = Zimmer.EingabeInt("Unterkunftsart? 1=Hotelzimer 2=Appartment");

            switch (Unterkunftsart)
            {
                case 1:
                    ZimmerKategorie = Zimmer.EingabeInt("Zimmerkategorie? 1=Standard 2=Komfort 3=Suite");
                    AnzahlGaeste = Zimmer.EingabeInt("Anzahl Erwachsene?");
                    Antwort = EingabeString("Kinder? j/n");

                    if (Antwort == "j")
                    {
                        AnzahlKinder = Zimmer.EingabeInt("Anzahl Kinder?");
                    }
                    Aufenthaltsdauer = Zimmer.EingabeInt("Aufenthaltsdauer?");

                    Zimmer Zimmerpreis = new Zimmer();
                    break;

                case 2:
                    //E: Aufenthaltsdauer
                    //E: Anzahl Gäste
                    break;

                default:
                    //Grundpreis audgeben
                    break;
            }



            Console.ReadKey();
        }
        public static string EingabeString(string aufforderung)
        {
            string antwort = "";
            Console.WriteLine(aufforderung);
            antwort = Console.ReadLine();
            return antwort;
        }
    }
}
