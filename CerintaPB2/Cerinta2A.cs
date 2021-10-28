using Problema1Arbori.Servicii;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1Arbori.CerintaPB2
{
    class Cerinta2A
    {
        int max = int.MinValue;

        public Cerinta2A(Ierarhie<int> ierarhie, int X)
        {
            minim(ierarhie.find(ierarhie.Root, X));
            Console.WriteLine(max);
        }

        public void minim(TreeNode<int> node)
        {
            if (node == null)
                return;

            if (node.Data > max)
                max = node.Data;

            minim(node.Left);
            minim(node.Right);
        }
    }
}
