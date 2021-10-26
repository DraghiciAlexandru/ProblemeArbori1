using Problema1Arbori.Servicii;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1Arbori.Cerinte
{
    class CerintaA
    {
        public CerintaA(Ierarhie<int> ierarhie, int nr)
        {
            inlocuieste(ierarhie.Root, nr);
        }

        public void inlocuieste(TreeNode<int> node, int nr)
        {
            if (node == null)
                return;

            if (node.Data == nr)
                node.Data = oglindit(nr);

            inlocuieste(node.Left, nr);
            inlocuieste(node.Right, nr);
        }

        public int oglindit(int nr)
        {
            int obl = 0;

            while (nr > 0) 
            {
                obl = obl * 10 + nr % 10;
                nr = nr / 10;
            }

            return obl;
        }
    }
}
