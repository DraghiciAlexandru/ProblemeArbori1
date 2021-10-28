using Problema1Arbori.CerintaPB2;
using Problema1Arbori.Cerinte;
using Problema1Arbori.Servicii;
using System;

namespace Problema1Arbori
{
    class Program
    {
        static void Main(string[] args)
        {
            Ierarhie<String> ierarhie = new Ierarhie<String>("8");
            ierarhie.addSubordinate("8", "3");
            ierarhie.addSubordinate("8", "10");
            ierarhie.addSubordinate("3", "1");
            ierarhie.addSubordinate("3", "6");
            ierarhie.addSubordinate("6", "4");
            ierarhie.addSubordinate("6", "7");
            ierarhie.addSubordinate("10", "14");
            ierarhie.addSubordinate("14", "13");

            Cerinta2E cerintaB = new Cerinta2E(ierarhie, "1 3 4 6 7 8 13 14 10");

        }
    }
}
