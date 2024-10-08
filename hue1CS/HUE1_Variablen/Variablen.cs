/* To DO:
    Typenkonvertierung vereinfachen, Hauptanwendungsbeispiele raussuchen, Hilfsklasse "parsen" 

*/

using System;
using System.Diagnostics;

namespace HUE1
{
    class Variablen
    {
        static void Main()
        {
            // Deklaration der Variablen
            int integer_variable;
            float float_variable;
            double double_variable;
            string string_variable;

            // Initialisierung der Variablen
            integer_variable = 10;
            float_variable = 7.18f;
            double_variable = 3.14;
            string_variable = "Hallo";

            // Deklaration und Initialisierung 
            bool booolean_variable = true;

            // Ausgabe von Variablen
            Console.Write("Integer: " + integer_variable + "\n");
            Console.WriteLine("Float: " + float_variable);
            Console.WriteLine("Double: " + double_variable);
            Console.WriteLine("String: " + string_variable);
            Console.WriteLine("Booelan: " + booolean_variable);
            Console.Write("\n \n");

            // logische Operatoren
            bool stimmtDas;
            stimmtDas = 5 > 4.5;
            Console.WriteLine("Die Aussage 5 > 4.5 ist " + stimmtDas);
            stimmtDas = (5 > 4.5) && (116.4 < (int)116.999);
            Console.WriteLine("Die Aussage (5 > 4.5) && (116.4 < (int)116.999) ist " + stimmtDas);
            Console.Write("\n \n");

            // Typenkonvertierung

            // Implizite Umwandlung
            double new_float_variable;
            new_float_variable = float_variable;
            Console.WriteLine("Implizite Umwandlung von Float " + float_variable + " zu Double: " + new_float_variable);

            double new_integer_variable;
            new_integer_variable = integer_variable;
            Console.WriteLine("Implizie Umwandlung von Integer " + integer_variable + " zu Double " + new_integer_variable);

            // Explizite Umwandelung (Casting)
            int d_neu = (int)double_variable;
            Console.WriteLine("Explizite Umwandlung (Casting) von Double " + double_variable + " zu Integer: " + d_neu);

            // Konvertierung mit Hilfsklassen: Double zu Int
            Console.Write("Bitte eine Gleitkommazahl eingeben: ");
            string eingabe = Console.ReadLine() ?? "";
            Debug.WriteLine("1. Eingabe: " + eingabe); // Anzeigen der Eingabe im Debug-Fenster
            double double_zahl = double.Parse(eingabe);
            int int_zahl = 0;
            int_zahl = Convert.ToInt32(double_zahl); // Mit Hilfe der System-Methode Convert.ToInt32
            Debug.WriteLine(int_zahl);
            
            // Oder explizit (Casting)
            int_zahl = (int)double_zahl;
            Debug.WriteLine(int_zahl);
            Console.WriteLine("Double: " + double_zahl);
            Console.WriteLine("Integer: " + int_zahl);

            // Konvertierung von Int zu Double
            Console.Write("Bitte eine ganze Zahl eingeben: ");
            eingabe = Console.ReadLine() ?? "";
            Debug.WriteLine("2. Eingabe: " + eingabe); // Anzeigen der Eingabe im Debug-Fenster
            int_zahl = int.Parse(eingabe); // Hilfsklasse int.Parse von int
            double_zahl = 0;
            double_zahl = Convert.ToDouble(int_zahl); // Mit Hilfe der System-Methode Convert.ToDouble
            Debug.WriteLine(double_zahl);
            
            // Oder implizit
            double_zahl = int_zahl;
            Console.WriteLine("Double: " + double_zahl);

        }

    }
}