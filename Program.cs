using System;

namespace Hotelangebotssoftware
{
    struct ZimmerPreis
    {
        public string Kategorie;
        public int MaxAnzahlErwachsene;
        public int MaxAnzahlKinder;
        public double RabattKinder;
        public double Preis;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int Unterkunftsart = 0;
            int AnzahlGaeste = 0;
            int AnzahlKinder = 0;
            int Aufenthaltsdauer = 0;
            double MwStA = 19;
            int Kategorie = 0;
            string Antwort = "";
            double Gesamtpreis = 0d;


            ZimmerPreis[] ZimmerPreis = new ZimmerPreis[]
            {
                new ZimmerPreis
                {
                    Kategorie = "Standard",
                    MaxAnzahlErwachsene =2,
                    MaxAnzahlKinder=2,
                    RabattKinder=25d,
                    Preis=50d
                },
            };
            //ZimmerPreis[0].Kategorie = Convert.ToString(Hotelangebotssoftware.Kategorie.Standard);
            //ZimmerPreis[0].MaxAnzahlErwachsene = 2;
            //ZimmerPreis[0].MaxAnzahlKinder = 2;
            //ZimmerPreis[0].RabattKinder = 25d;
            //ZimmerPreis[0].Preis = 50d;

            //ZimmerPreis[1].Kategorie = Convert.ToString(Hotelangebotssoftware.Kategorie.Komfort);
            //ZimmerPreis[1].MaxAnzahlErwachsene = 4;
            //ZimmerPreis[1].MaxAnzahlKinder = 2;
            //ZimmerPreis[1].RabattKinder = 25d;
            //ZimmerPreis[1].Preis = 80d;

            //ZimmerPreis[2].Kategorie = Convert.ToString(Hotelangebotssoftware.Kategorie.Suite);
            //ZimmerPreis[2].MaxAnzahlErwachsene = 6;
            //ZimmerPreis[2].MaxAnzahlKinder = 4;
            //ZimmerPreis[2].RabattKinder = 25d;
            //ZimmerPreis[2].Preis = 120d;

            Zimmer Zimmer = new Zimmer();

            Unterkunftsart = Zimmer.EingabeInt("Unterkunftsart? 1=Hotelzimer 2=Appartment");

            switch (Unterkunftsart)
            {
                case 1:
                    Kategorie = Zimmer.EingabeInt("Zimmerkategorie? 1=Standard 2=Komfort 3=Suite") - 1;
                    AnzahlGaeste = Zimmer.EingabeInt("Anzahl Erwachsene?");
                    Antwort = EingabeString("Kinder? j/n");

                    if (Antwort == "j")
                    {
                        AnzahlKinder = Zimmer.EingabeInt("Anzahl Kinder?");
                    }
                    Aufenthaltsdauer = Zimmer.EingabeInt("Aufenthaltsdauer?");

                    Zimmer Zimmerpreis = new Zimmer(ZimmerPreis[Kategorie].Kategorie, ZimmerPreis[Kategorie].RabattKinder, ZimmerPreis[Kategorie].MaxAnzahlKinder, ZimmerPreis[Kategorie].Preis, ZimmerPreis[Kategorie].MaxAnzahlErwachsene, MwStA);

                    Zimmerpreis.AnzahlGaeste = AnzahlGaeste;
                    Zimmerpreis.AnzahlKinder = AnzahlKinder;
                    Zimmerpreis.Aufenthaltsdauer = Aufenthaltsdauer;

                    Gesamtpreis = Zimmerpreis.BerechneGesamtpreis();
                    Console.WriteLine(Gesamtpreis);

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
