using Problema1Arbori.Servicii;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1Arbori.Cerinte
{
    class CerintaJ
    {
        int s = 0;

        public CerintaJ(Ierarhie<int> ierarhie)
        {
            sumaMijloc(ierarhie.Root);

            Console.WriteLine(s);
        }

        public void sumaMijloc(TreeNode<int> node, int suma = 0)
        {
            if (node == null)
                return;

            int m = mijloc(node.Data);

            if (m > 9)
                m = m % 10 + m / 10;

            if (perfect(m % 10)) 
            {
                Console.WriteLine(node.Data);
                s += node.Data;
            }

            sumaMijloc(node.Left);
            sumaMijloc(node.Right);
        }

        public int mijloc(int nr)
        {
            if(nr>99)
            {
                nr = nr / 10;

                int aux = 0, p = 1;

                while (nr > 9) 
                {
                    aux = (nr % 10) * p + aux;
                    p *= 10;
                    nr = nr / 10;
                }

                nr = aux;

                return mijloc(nr);
            }

            return nr;
        }

        public bool perfect(int nr)
        {
            if (Math.Sqrt(nr) == (int)Math.Sqrt(nr))
                return true;
            return false;
        }
    }
}
