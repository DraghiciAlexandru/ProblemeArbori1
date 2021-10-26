using Problema1Arbori.Servicii;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1Arbori.Cerinte
{
    class CerintaE
    {
        public CerintaE(Ierarhie<int> ierarhie)
        {
            gemene(ierarhie.Root);
        }

        public void gemene(TreeNode<int> node)
        {
            if (node == null)
                return;
            if (node.Left != null && node.Right != null)
                if (node.Left.Data == node.Right.Data)
                    Console.WriteLine(node.Data);

            gemene(node.Left);
            gemene(node.Right);
        }
    }
}
