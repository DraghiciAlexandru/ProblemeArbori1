using Problema1Arbori.Servicii;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1Arbori.CerintaPB2
{
    class Cerinta2B
    {
        int max = int.MinValue;

        public Cerinta2B(Ierarhie<int> ierarhie)
        {
            minim(ierarhie.Root);
            Console.WriteLine(max);
        }

        public void minim(TreeNode<int> node)
        {
            if (node == null)
                return;
            if (produsCifre(node.Data) != 0)
                if (node.Data > max && node.Data % produsCifre(node.Data) == 0)
                    max = node.Data;

            minim(node.Left);
            minim(node.Right);
        }

        public int produsCifre(int nr)
        {
            if (nr == 0)
                return 0;

            int p = 1;

            while (nr > 0)
            {
                p *= nr % 10;
                nr = nr / 10;
            }

            return p;
        }
    }
}
