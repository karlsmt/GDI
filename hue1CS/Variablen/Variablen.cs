using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hue1.Variablen
{
    public class Variablen
    {
        public static void Main()
        {
            byte b;
            int i;
            float f;
            double d;
            char c;
            Boolean bo;
            int d_neu;
            double i_neu;
            Boolean stimmtDas;

            b = 127;
            i = 2147483647;
            f = 3.14159f;
            d = 264.967;
            c = 'a';
            bo = true;


            Console.WriteLine("Byte: " + b);
            //mit /n im String kann eine neue Zeile im Textfeld erzeugt werden
            //damit können einfache Textformatierungen zur Übersicht im String erzeugt werden
            //Es gibt auch \r \f
            Console.Write("Integer: " + i);
            Console.Write("\nFloat: " + f);
            Console.WriteLine("Double: " + d);
            Console.WriteLine("Char: " + c);
            Console.WriteLine("Booelan: " + bo);
            Console.Write("\n \n");

            //Casting
            d_neu = (int)d;
            Console.WriteLine("Casting von Double " + d + " zu Integer: " + d_neu);

            // implizite Umwandlung
            i_neu = i;
            Console.WriteLine("Implizite Umwandlung von Integer\n" + i + " zu Double: " + i_neu);

            Console.Write("\n \n");
            // logische Audrücke
            stimmtDas = 5 > 4.5;
            Console.WriteLine("Die Aussage 5 > 4.5 ist " + stimmtDas);

            stimmtDas = (5 > 4.5) && (116.4 < (int)116.999);
            Console.WriteLine("Die Aussage (5 > 4.5) && (116.4 < (int)116.999) ist " + stimmtDas);

            /*
             * Konvertierung von Double zu Int
             */
            //Hilfsklasse double.Parse von double
            Console.Write("Bitte eine Zahl eingeben: ");
            string eingabe = Console.ReadLine() ?? "";
            //anzeigen der EIngabe im Debug-Fenster
            Debug.WriteLine("1.Eingabe: "+eingabe);
            double double_zahl = double.Parse(eingabe);
            int int_zahl = 0;
            // mit Hilfe der System-Methode Convert.ToInt32
            int_zahl = Convert.ToInt32(double_zahl);
            Debug.WriteLine(int_zahl);
            // oder explizit (Casting)
            int_zahl = (int)double_zahl;
            Debug.WriteLine(int_zahl);
            Console.WriteLine("Double: " + double_zahl);
            Console.WriteLine("Integer: " + int_zahl);


            /*
             * Konvertierung von Int zu Double
             */
            Console.Write("Bitte eine ganze Zahl eingeben: ");
            eingabe = Console.ReadLine() ?? "";
            //anzeigen der EIngabe im Debug-Fenster
            Debug.WriteLine("2.Eingabe: " + eingabe);
            //Hilfsklasse int.Parse von int
            int_zahl = int.Parse(eingabe);
            double_zahl = 0;
            // mit Hilfe der System Methode
            double_zahl = Convert.ToDouble(int_zahl);
            Debug.WriteLine(double_zahl);
            // oder implizit
            double_zahl = int_zahl;

            Console.WriteLine("Double: " + double_zahl);

        }

    }
}