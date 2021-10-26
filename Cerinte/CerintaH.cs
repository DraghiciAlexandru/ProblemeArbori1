using Problema1Arbori.Servicii;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1Arbori.Cerinte
{
    class CerintaH
    {
        public CerintaH(Ierarhie<int> ierarhie, int X)
        {
            Console.WriteLine(ierarhie.height(ierarhie.Root));
            Console.WriteLine(ierarhie.nivel(ierarhie.Root, X));
        }
    }
}
