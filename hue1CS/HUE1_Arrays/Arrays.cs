using System;


namespace HUE1
{
    class Arrays
    {
        static void Main()
        {
            double[] zahlen;
            double summe;

            zahlen = new double[3];
            zahlen[0] = System.Math.PI;   // PI
            zahlen[1] = 2.718281828;  // e
            zahlen[2] = 42;     // Antwort
            summe = zahlen[0] + zahlen[1] + zahlen[2];
            Console.WriteLine("Summe Zahlen: " + summe);

            int[] ganzeZahlen = { 5, 7, 12 };

            double summe2 = ganzeZahlen[0] + ganzeZahlen[1] + ganzeZahlen[2];
            Console.WriteLine("Summe ganze Zahlen : " + summe2);


            string beispiel = "Hallo GDI";

            Console.WriteLine("1. Buchstabe = " + beispiel[0]);
            Console.WriteLine("letzter Buchstabe = " + beispiel[beispiel.Length - 1]);
        }

    }
}