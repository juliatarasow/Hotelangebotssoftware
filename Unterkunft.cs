using System;

namespace Hotelangebotssoftware
{

    public class Unterkunft
    {
        //Felder/Properties
        internal double Grundpreis { get; private set; }
        private int aufenthaltsdauer;
        internal int Aufenthaltsdauer { get { return GetAufentahltsdauer(); } set { SetAufenthaltsdauer(value); } }
        private int anzhalGaeste;
        internal int AnzahlGaeste { get { return GetAnzahlGaeste(); } set { SetAnzahlGaeste(value); } }
        internal int MaxAnzahlGaeste { get; private set; }
        internal double MwStA { get; private set; }

        //Konstruktor 
        internal Unterkunft() { }
        internal Unterkunft(double grundpreis, int maxAnzahlGaeste, double mwStA)
        {
            this.Grundpreis = grundpreis;
            this.MaxAnzahlGaeste = maxAnzahlGaeste;
            this.MwStA = mwStA;
        }

        //Tooltip beim Benutzen
        /// <summary>
        /// Diese Funktion berechnet den Gesamtpreis
        /// </summary>
        /// <returns></returns>

        //Funktion
        internal double BerechneGesamtpreis()
        {
            double Gesamtpreis = 0d;
            double GesamtpreisBrutto = 0d;
            double MwStABetrag = 0d;

            Gesamtpreis = Grundpreis * Aufenthaltsdauer * AnzahlGaeste;
            MwStABetrag = Gesamtpreis * MwStA / 100;
            GesamtpreisBrutto = Gesamtpreis + MwStABetrag;

            return GesamtpreisBrutto;
        }

        public int EingabeInt(string aufforderung)
        {
            int antwort = 0;
            Console.WriteLine(aufforderung);
            string eingabeZahl = Console.ReadLine();
            antwort = Convert.ToInt32(eingabeZahl);
            return antwort;
        }

        public void IntSpeichern(int variablenname)
        {
            //Prüfung, ob Eingabe == int
            string eingabeWert = Console.ReadLine();
            variablenname = Convert.ToInt32(eingabeWert);

        }

        //public double BerechneGesamtpreis(out double MsStABetrag)
        //{
        //    double Gesamtpreis = 0d;
        //    double GesamtpreisBrutto = 0d;

        //    Gesamtpreis = Grundpreis * Aufenthaltsdauer * AnzahlGaeste;
        //    MsStABetrag = Gesamtpreis * MwStA / 100;
        //    GesamtpreisBrutto = Gesamtpreis + MsStABetrag;
        //    return GesamtpreisBrutto;
        //}

        //Prozedur
        internal void ZeigeLeistungsBeschreibung()
        {
            Console.WriteLine($"Gesamtsumme: {BerechneGesamtpreis()} Euro.");
        }

        internal int GetAufentahltsdauer()
        {
            return aufenthaltsdauer;
        }

        internal void SetAufenthaltsdauer(int value)
        {
            //this.Aufenthaltsdauer = 0;
            if (value > 0)
            {
                aufenthaltsdauer = value;
            }
        }

        internal int GetAnzahlGaeste()
        {
            return anzhalGaeste;
        }

        internal void SetAnzahlGaeste(int value)
        {
            //this.AnzahlGaeste = -1;
            if (value > 0)
            {
                anzhalGaeste = value;
            }
        }
    }
}
