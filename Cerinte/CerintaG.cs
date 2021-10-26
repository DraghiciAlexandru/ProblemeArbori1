using Problema1Arbori.Servicii;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1Arbori.Cerinte
{
    class CerintaG
    {
        int m = int.MinValue;

        public CerintaG(Ierarhie<int> ierarhie, int Z)
        {
            maxim(ierarhie.find(ierarhie.Root, Z).Right);
            Console.WriteLine(m);
        }

        public void maxim(TreeNode<int> node)
        {
            if (node == null)
                return;

            if (node.Data > m)
                m = node.Data;

            maxim(node.Left);
            maxim(node.Right);
        }
    }
}
