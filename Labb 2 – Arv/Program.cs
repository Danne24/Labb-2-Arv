using System;

namespace Labb_2___Arv
{
    public class Djur
    {
        public string _namn;
        public int _antalBen;
        public string _färg;
        public double _höjdIMeter;
        public double _viktIKg;

        public Djur() : this("Inget inmatat namn!", 0, "Ingen inmatad färg!", 0.0, 0.0)
        {

        }

        public Djur(string namn, int antalBen, string färg, double höjdIMeter, double viktIKg)
        {
            this._namn = namn;
            this._antalBen = antalBen;
            this._färg = färg;
            this._höjdIMeter = höjdIMeter;
            this._viktIKg = viktIKg;
        }

        public void Print()
        {
            Console.WriteLine("Djurets namn är: {0}.", _namn);
            Console.WriteLine("Antal ben som djuret har är: {0}.", _antalBen);
            Console.WriteLine("Djurets färg är: {0}", _färg);
            Console.WriteLine("Djurets höjd i meter är: {0}", _höjdIMeter);
            Console.WriteLine("Djurets vikt i kilogram är: {0}", _viktIKg);
        }

        public void MakeSound()
        {
            Console.WriteLine("{0}en gör ett ljud!", _namn);
        }

        public void Äter()
        {
            Console.WriteLine("{0} äter!", _namn);
        }

        public void Springer()
        {
            Console.WriteLine("{0} springer!", _namn);
        }

        public void Hoppar()
        {
            Console.WriteLine("{0} Hoppar!", _namn);
        }
    }

    public class Björn : Djur
    {
        public bool _gårIIdePåVintern;
        public Björn() : this("Björn", 4, "Brun", 2.5, 500.0, true)
        {

        }
        public Björn(string namn, int antalBen, string färg, double höjdIMeter, double viktIKg, bool gårIIdePåVintern)
        {
            this._namn = namn;
            this._antalBen = antalBen;
            this._färg = färg;
            this._höjdIMeter = höjdIMeter;
            this._viktIKg = viktIKg;
            this._gårIIdePåVintern = gårIIdePåVintern;
        }
        public new void MakeSound()
        {
            Console.WriteLine("Björnen gör ett ljud!");
        }
        public void GårIIdePåVintern()
        {
            Console.WriteLine("Björnen kommer att gå i ide på vintern.");
        }
        public void ÄterFisk()
        {
            Console.WriteLine("Björnen äter fisk.");
        }
    }

    public class Isbjörn : Björn
    {
        public bool _ÄrUtrotningshotad;
        public Isbjörn() : this("Isbjörn", 4, "vit", 2.4, 450.0, true, true)
        {

        }
        public Isbjörn(string namn, int antalBen, string färg, double höjdIMeter, double viktIKg, bool gårIIdePåVintern, bool ärUtrotningshotad)
        {
            this._namn = namn;
            this._antalBen = antalBen;
            this._färg = färg;
            this._höjdIMeter = höjdIMeter;
            this._viktIKg = viktIKg;
            this._gårIIdePåVintern = gårIIdePåVintern;
            this._ÄrUtrotningshotad = ärUtrotningshotad;
        }
        public new void MakeSound()
        {
            Console.WriteLine("Isbjörnen gör ett ljud!");
        }
        public new void GårIIdePåVintern()
        {
            Console.WriteLine("Isbjörnen kommer att gå i ide på vintern.");
        }
        public new void ÄterFisk()
        {
            Console.WriteLine("Isbjörnen äter fisk.");
        }
        public void LeverPåNordpolen()
        {
            Console.WriteLine("Isbjörnar lever bara på nordpolen.");
        }
    }

    public class Grizzlybjörn : Björn
    {
        public bool _HarLångaKlor;
        public Grizzlybjörn() : this("Grizzlybjörn", 4, "grå", 2, 270, true, true)
        {

        }
        public Grizzlybjörn(string namn, int antalBen, string färg, double höjdIMeter, double viktIKg, bool gårIIdePåVintern, bool harLångaKlor)
        {
            this._namn = namn;
            this._antalBen = antalBen;
            this._färg = färg;
            this._höjdIMeter = höjdIMeter;
            this._viktIKg = viktIKg;
            this._gårIIdePåVintern = gårIIdePåVintern;
            this._HarLångaKlor = harLångaKlor;
        }
        public new void MakeSound()
        {
            Console.WriteLine("Grizzlybjörnen gör ett ljud!");
        }
        public new void GårIIdePåVintern()
        {
            Console.WriteLine("Grizzlybjörnen kommer att gå i ide på vintern.");
        }
        public new void ÄterFisk()
        {
            Console.WriteLine("Grizzlybjörnen äter fisk.");
        }
        public void LeverINordamerika()
        {
            Console.WriteLine("Grizzlybjörnar lever bara i nordamerika.");
        }
    }

    public class Fågel : Djur
    {
        public bool _kanFlyga;
        public Fågel() : this("Fågel", 2, "Vit", 0.45, 0.430, true)
        {

        }
        public Fågel(string namn, int antalBen, string färg, double höjdIMeter, double viktIKg, bool kanFlyga)
        {
            this._namn = namn;
            this._antalBen = antalBen;
            this._färg = färg;
            this._höjdIMeter = höjdIMeter;
            this._viktIKg = viktIKg;
            this._kanFlyga = kanFlyga;
        }
        public new void MakeSound()
        {
            Console.WriteLine("Fågeln gör ett ljud!");
        }
        public void Flyger()
        {
            Console.WriteLine("Fågeln flyger!");
        }
        public void LäggerEttÄgg()
        {
            Console.WriteLine("Fågeln Lägger ett ägg!");
        }
    }

    public class Katt : Djur
    {
        public bool _harEnSvans;
        public Katt() : this("Katt", 4, "Orange", 0.25, 4.3, true)
        {

        }
        public Katt(string namn, int antalBen, string färg, double höjdIMeter, double viktIKg, bool harEnSvans)
        {
            this._namn = namn;
            this._antalBen = antalBen;
            this._färg = färg;
            this._höjdIMeter = höjdIMeter;
            this._viktIKg = viktIKg;
            this._harEnSvans = harEnSvans;
        }
        public new void MakeSound()
        {
            Console.WriteLine("Katten gör ett ljud!");
        }
        public void Leker()
        {
            Console.WriteLine("Katten leker!");
        }
        public void Spinner()
        {
            Console.WriteLine("Katten spinner!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Björn björn1 = new Björn();
            björn1.Print();
            björn1.MakeSound();
            björn1.GårIIdePåVintern();
            björn1.ÄterFisk();
            björn1.Äter();
            björn1.Springer();
            björn1.Hoppar();

            Console.WriteLine(" ");

            Isbjörn isbjörn1 = new Isbjörn();
            isbjörn1.Print();
            isbjörn1.MakeSound();
            isbjörn1.GårIIdePåVintern();
            isbjörn1.ÄterFisk();
            isbjörn1.Äter();
            isbjörn1.Springer();
            isbjörn1.Hoppar();
            isbjörn1.LeverPåNordpolen();

            Console.WriteLine(" ");

            Grizzlybjörn grizzlybjörn1 = new Grizzlybjörn();
            grizzlybjörn1.Print();
            grizzlybjörn1.MakeSound();
            grizzlybjörn1.GårIIdePåVintern();
            grizzlybjörn1.ÄterFisk();
            grizzlybjörn1.Äter();
            grizzlybjörn1.Springer();
            grizzlybjörn1.Hoppar();
            grizzlybjörn1.LeverINordamerika();

            Console.WriteLine(" ");

            Fågel fågel1 = new Fågel();
            fågel1.Print();
            fågel1.MakeSound();
            fågel1.Flyger();
            fågel1.LäggerEttÄgg();
            fågel1.Äter();
            fågel1.Springer();
            fågel1.Hoppar();

            Console.WriteLine(" ");

            Katt katt1 = new Katt();
            katt1.Print();
            katt1.MakeSound();
            katt1.Leker();
            katt1.Spinner();
            katt1.Äter();
            katt1.Springer();
            katt1.Hoppar();

            Console.WriteLine(" ");

            Djur elefant = new Djur("Elefant", 4, "grå", 3.2, 4000);
            elefant.MakeSound();
            Djur häst = new Djur("Häst", 4, "brun", 1.6, 400);
            häst.MakeSound();
            Djur hund = new Djur("Hund", 4, "svart", 35, 5);
            hund.MakeSound();
        }
    }
}
