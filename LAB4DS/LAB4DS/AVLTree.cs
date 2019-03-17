﻿namespace LAB4DS
{
    class AVLTree
    {
        public class Node
        {
            public int data;
            public int height;
            public Node left, right;

            public Node(int data = 0)
            {
                this.data = data;
            }
        }

        public Node top;

        public int Heigth(Node element)
        {
            if (element != null) return element.height;
            return 0;
        }

        public int BalanceFactor(Node element)
        {
            return Heigth(element.right) - Heigth(element.left);
        }

        public void CalcHeight(Node element)
        {
            int hLeft = Heigth(element.left);
            int hRight = Heigth(element.right);
            element.height = (hLeft > hRight ? hLeft : hRight) + 1;
        }

        public Node leftRotare(Node l)
        {
            Node r = l.right;

            l.right = r.left;
            r.left = l;

            CalcHeight(l);
            CalcHeight(r);

            return r;
        }

        public Node rightRotate(Node r)
        {
            Node l = r.left;
            r.left = l.right;
            l.right = r;

            CalcHeight(l);
            CalcHeight(r);

            return l;
        }

        public Node Balancing(Node element)
        {
            CalcHeight(element);
            if(BalanceFactor(element) == 2)
            {
                if (BalanceFactor(element.right) < 0)
                    element.right = rightRotate(element.right);
                element = leftRotare(element);
                return element;
            }
            else if(BalanceFactor(element) == -2)
            {
                if (BalanceFactor(element.left) > 0)
                    element.left = leftRotare(element.left);
                element = rightRotate(element);
                return element;
            }
            return element;
        }

        public Node Insert (Node element, int data)
        {
            if (element == null)
                return new Node(data);

            if (data < element.data)
                element.left = Insert(element.left, data);
            else
                element.right = Insert(element.right, data);
            return Balancing(element);
        }

        public void Add(int data)
        {
            top = Insert(top, data);
        }

        public Node FindLeft(Node element)
        {
            if (element.left != null) return FindLeft(element.left);
            return element;
        }

        public Node RemoveMin(Node element)
        {
            if (element.left == null)
                return element.right;
            element.left = RemoveMin(element.left);
            return Balancing(element);
        }

        public Node Remove(Node element, int data)
        {
            if (element == null) return null;
            if (data < element.data)
                element.left = Remove(element.left, data);
            else if (data > element.data)
                element.right = Remove(element.right, data);
            else
            {
                Node q = element.left;
                Node r = element.right;

                if (r == null) return q;

                Node min = FindLeft(r);
                min.left = RemoveMin(r);
                min.left = q;
                return Balancing(min);
            }
            return Balancing(element);
        }

        public void Delete(int data)
        {
            top = Remove(top, data);
        }

        public void Infix(Node top)
        {
            if (top == null) return;
            Infix(top.left);
            System.Console.Write(top.data +" ");
            Infix(top.right);
        }

        public void Prefix(Node top)
        {
            if (top == null) return;
            System.Console.Write(top.data + " ");
            Prefix(top.left);
            Prefix(top.right);
        }

        public void Postfix(Node top)
        {
            if (top == null) return;
            Postfix(top.left);
            Postfix(top.right);
            System.Console.Write(top.data + " ");
        }

        public bool Find(int data)
        {
            Node p = top;
            while (p != null)
            {
                if (data < p.data)  p = p.left; 
                if (data > p.data)  p = p.right;
                if (p.data == data) return true; 
            }
            return false;
        }
    }
}
