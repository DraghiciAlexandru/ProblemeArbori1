using Problema1Arbori.Servicii;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1Arbori.Cerinte
{
    class CerintaD
    {
        Ierarhie<int> ierarhie;

        int[,] node_uri;

        public CerintaD(Ierarhie<int> ierarhie, int Y)
        {
            this.ierarhie = ierarhie;

            node_uri = new int[ierarhie.grad(ierarhie.Root) + 1, 2];

            vector(ierarhie.Root);

            for (int i = 0; i < ierarhie.grad(ierarhie.Root) + 1; i++) 
            {
                if (node_uri[i, 1] == Y)
                    Console.WriteLine(i);
            }
        }

        public void vector(TreeNode<int> node)
        {
            Queue<TreeNode<int>> queue = new Queue<TreeNode<int>>();

            queue.Enqueue(node);

            int poz = 0;

            while (queue.Count != 0)
            {
                if (queue.Peek().Left != null)
                {
                    queue.Enqueue(queue.Peek().Left);
                }
                if (queue.Peek().Right != null)
                {
                    queue.Enqueue(queue.Peek().Right);
                }

                node_uri[poz, 1] = queue.Dequeue().Data;
                poz++;
            }
        }

    }
}
