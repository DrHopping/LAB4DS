using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4DS
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTree tree = new AVLTree();
            
            tree.Add(3);
            tree.Add(4);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(5);
            tree.Add(8);
            tree.Add(9);
            tree.Add(11);
            tree.Add(12);

            // Console.WriteLine(tree.top.left.left.data);

            Console.WriteLine("Tree top " + tree.top.data);
            tree.Infix(tree.top);
            Console.WriteLine();
            tree.Prefix(tree.top);
            Console.WriteLine();
            tree.Postfix(tree.top);
            Console.WriteLine();

            //tree.Delete(5);
            //Console.WriteLine("Tree top " + tree.top.data);
            //tree.Infix(tree.top);
            Console.ReadLine();
        }
    }
}
