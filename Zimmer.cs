using System;

namespace Hotelangebotssoftware
{
    public enum Kategorie
    {
        Standard, Komfort, Suite
    }

    public class Zimmer : Unterkunft
    {
        internal Kategorie Kategorie { get; set; }
        private double rabattKinder;
        internal double RabattKinder { get { return this.rabattKinder; } private set { SetRabattKinder(value); } }
        internal int AnzahlKinder { get; set; }
        private int maxAnzahlKinder;
        internal int MaxAnzahlKinder { get { return this.maxAnzahlKinder; } private set { SetMaxAnzahlKinder(value); } }

        internal Zimmer() { }
        internal Zimmer(double grundpreis, int maxAnzahlGaeste, double mwStA):base(grundpreis, maxAnzahlGaeste, mwStA) { }

        internal Zimmer(string kategorie, double rabattKinder, int maxAnzahlKinder, double grundpreis, int maxAnzahlGaeste, double mwStA) : base(grundpreis, maxAnzahlGaeste, mwStA) { }
        
        public new double BerechneGesamtpreis()
        {
            double Gesamtpreis = 0d;
            if (AnzahlKinder <= MaxAnzahlKinder)
            {
                Gesamtpreis = base.BerechneGesamtpreis() + AnzahlKinder * RabattKinder;
            }
            else
            {
                Console.WriteLine($"Geben Sie eine Anzahl von Kindern zwischen 0 und {MaxAnzahlKinder}");
            }

            return Gesamtpreis;
        }

        internal void SetRabattKinder(double value)
        {
            this.rabattKinder = value;
        }

        internal void SetMaxAnzahlKinder(int value)
        {
            value = this.maxAnzahlKinder;
        }
    }
}
