using Problema1Arbori.Servicii;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1Arbori.Cerinte
{
    class CerintaC
    {
        int ct = 0;

        public CerintaC(Ierarhie<int> ierarhie)
        {
            nrFrunzePerf(ierarhie.Root);
            Console.WriteLine(ct);
        }

        public void nrFrunzePerf(TreeNode<int> node)
        {
            if (node == null)
                return;

            if (node.Left == null && node.Right == null && perfect(node.Data)) 
            {
                ct++;
                return;
            }

            nrFrunzePerf(node.Left);
            nrFrunzePerf(node.Right);
        }

        public bool perfect(int nr)
        {
            if (Math.Sqrt(nr) == (int)Math.Sqrt(nr))
                return true;
            return false;
        }
    }
}
