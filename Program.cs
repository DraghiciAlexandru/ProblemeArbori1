using Problema1Arbori.Cerinte;
using Problema1Arbori.Servicii;
using System;

namespace Problema1Arbori
{
    class Program
    {
        static void Main(string[] args)
        {
            Ierarhie<int> ierarhie = new Ierarhie<int>(8);
            ierarhie.addSubordinate(8, 3);
            ierarhie.addSubordinate(8, 10);
            ierarhie.addSubordinate(3, 1);
            ierarhie.addSubordinate(3, 9);
            ierarhie.addSubordinate(9, 4);
            ierarhie.addSubordinate(9, 7);
            ierarhie.addSubordinate(10, 14);
            ierarhie.addSubordinate(14, 13);

            CerintaJ cerintaB = new CerintaJ(ierarhie);

        }
    }
}
