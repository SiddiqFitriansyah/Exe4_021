using System;

namespace Exe4_021
{
    class Siddiq
    {
        public string info;
        public Siddiq next;
        public Siddiq(int i, Siddiq SF)
        {   
            next = SF;  
        }
    }
    class Stack
    {
        string [] Siddiq;
        private int top;
        private int max;
        public Stack(int size)
        {
            Siddiq = new string[size];
            top = -1;
            max = size;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void Push(string item)
        {
            if (top == max -1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                Siddiq[++top] = item;
            }
        }
        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine(" Poped Element is: " + Siddiq[top]);
                return top;
            }
        }
        public void Display()
        {
            Siddiq tmp;
            if (empty())
                Console.WriteLine("\nStack is Empty");
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + Siddiq[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Stack s = new Stack(41);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push the Element.");
                Console.WriteLine("2. Pop the Element");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\nEnter your choice");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a Number of Letter: ");
                        string num = Console.ReadLine();
                        s.Push(num);
                        break;
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\nStack Empty");
                            break;
                        }
                        s.Pop();
                        break;
                    case '3':
                        s.Display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }       
}