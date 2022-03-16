using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stunde_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Datentypen:ganze Zahlen; Dezimazahlen; zeichenketten; Zeichen
            //           Wahrheitswerte (Boolean)
            // ganze Zahlen:
            int ganzeZahlA = 41;
            int ganzeZahlB;
            ganzeZahlB = 7;
            short kleineGanzeZahl;
            long großeGanzeZahl;

            int ganzeZahlC = ganzeZahlA % ganzeZahlB;
            Console.WriteLine(ganzeZahlC);

            // GleitkommaZahlen ( Dezimalzahlen)
            double gleitkommaZahlA = 1.5;
            double gleitkommaZahlB = 3;
            decimal großeGleitkommazahl;

            Console.WriteLine(gleitkommaZahlA / gleitkommaZahlB);

            Console.WriteLine(gleitkommaZahlA + gleitkommaZahlB);

            double gleitkommazahlC = ganzeZahlC + gleitkommaZahlA;
            // int zu double -> kein Problem
            // double zu int -> braucht Eingereifen
            Console.WriteLine(gleitkommazahlC);

            bool wahrheitswert = true;
            // Später Mehr

            //Zeichen und Zeichenketten
            char Zeichen = '&';
            string ZeichenketteA = "Hallo"; 
            string ZeichenketteB = "welt";

            //String + string = Konkatenation
            Console.WriteLine(ZeichenketteA + ZeichenketteB);

        }
    }
}
