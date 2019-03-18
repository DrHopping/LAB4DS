using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4DS
{
    class Program
    {
        static AVLTree EnterTree()
        {
            AVLTree tree = new AVLTree();

            while (true)
            {
                Console.WriteLine("===================================================>GeneneratingTree<===================================================");
                Console.WriteLine("1.Add 2.Remove 3.Stop");
                Console.Write("Infix:"); tree.Infix(tree.top); Console.WriteLine();
                Console.Write("Prefix:"); tree.Prefix(tree.top); Console.WriteLine();
                Console.Write("Postfix:"); tree.Postfix(tree.top); Console.WriteLine();
                Console.Write("Choose operation: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Add: ");
                        tree.Add(int.Parse(Console.ReadLine()));
                        break;

                    case "2":
                        Console.Write("Remove: ");
                        tree.Delete(int.Parse(Console.ReadLine()));
                        break;

                    case "3":
                        Console.Clear();
                        return tree;
                        break;

                    default:
                        break;
                }
                Console.Clear();
            }
        }

        static void Main(string[] args)
        {
            AVLTree tree = EnterTree();

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
