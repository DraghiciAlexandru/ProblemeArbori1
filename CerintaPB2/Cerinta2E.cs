using Problema1Arbori.Servicii;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1Arbori.CerintaPB2
{
    class Cerinta2E
    {

        public Cerinta2E(Ierarhie<String> ierarhie, String s)
        {
            if (preorder(ierarhie.Root).TrimEnd() == s)
                Console.WriteLine("preorder");
            if (inorder(ierarhie.Root).TrimEnd() == s)
                Console.WriteLine("inorder");
            if (postorder(ierarhie.Root).TrimEnd() == s)
                Console.WriteLine("postorder");
        }

        String preorder(TreeNode<String> node)
        {
            if (node == null)
            {
                return "";
            }

            return node.Data + " " + preorder(node.Left) + preorder(node.Right);
        }

        String inorder(TreeNode<String> node)
        {
            if (node == null)
            {
                return "";
            }

            return inorder(node.Left) + node.Data + " " + inorder(node.Right);
        }

        String postorder(TreeNode<String> node)
        {
            if (node == null)
            {
                return "";
            }

            return postorder(node.Left) + postorder(node.Right) + node.Data + " ";
        }
    }
}
