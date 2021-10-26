using Problema1Arbori.Servicii;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1Arbori.Cerinte
{
    class CerintaB
    {
        public CerintaB(Ierarhie<int> ierarhie)
        {
            afisareFrunze(ierarhie.Root);
        }

        public void afisareFrunze(TreeNode<int> node)
        {
            if (node == null)
                return;

            if (node.Left == null && node.Right == null) 
            {
                Console.WriteLine(node.Data);
                return;
            }

            afisareFrunze(node.Left);
            afisareFrunze(node.Right);
        }
    }
}
