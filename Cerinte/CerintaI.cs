using Problema1Arbori.Servicii;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1Arbori.Cerinte
{
    class CerintaI
    {
        public Ierarhie<int> newIerarh;

        public CerintaI(Ierarhie<int> ierarhie)
        {
            newIerarh = new Ierarhie<int>(ierarhie.Root.Data * 10);

            built(ierarhie.Root);
        }

        public void built(TreeNode<int> node)
        {
            if (node == null)
                return;

            if (node.Left != null)
                newIerarh.addSubordinate(node.Data * 10, node.Left.Data * 10);
            if (node.Right != null)
                newIerarh.addSubordinate(node.Data * 10, node.Right.Data * 10);

            built(node.Left);
            built(node.Right);
        }

    }
}
