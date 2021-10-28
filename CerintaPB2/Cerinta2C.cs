using Problema1Arbori.Servicii;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1Arbori.CerintaPB2
{
    class Cerinta2C
    {
        int[] vector;
        int n = 0;

        public Cerinta2C(Ierarhie<int> ierarhie)
        {
            vector = new int[ierarhie.grad(ierarhie.Root) + 1];

            built(ierarhie.Root);

            for (int i = 0; i < n; i++)
                Console.WriteLine(vector[i]);
        }

        void built(TreeNode<int> node)
        {
            if (node == null)
                return;

            if(prim(node.Data))
            {
                vector[n] = node.Data;
                n++;
            }
            built(node.Left);
            built(node.Right);
        }

        public bool prim(int nr)
        {
            if (nr == 0 || nr == 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(nr); i++)
                if (nr % i == 0)
                    return false;
            return true;
        }
    }
}
