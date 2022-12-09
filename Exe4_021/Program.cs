using System;

namespace Exe4_021
{
    class Siddiq
    {
        public int info;
        public Siddiq next;
        private int[] a = new int[41];
        public Siddiq(int i, Siddiq S)
        {
            info = i;
            next = null;
        }
    }
    class Stack
    {
        private int[] ele;
        private int top;
        private int max;
        public Stack(int size)
        {
            ele = new int[size];
            top = -1;
            max = size;
        }
        public void Push(int item)
        {
            if (top == max-1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                ele[++top] = item;
            }
        }
        public int Pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine(" Poped Element is: " + ele[top]);
                return ele[top--];
            }
        }
        public void Display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + ele[i]);
                }
            }
        }
    }
}