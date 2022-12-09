using System;

namespace Exe4_021
{
    class Siddiq
    {
        public int info;
        public Siddiq next;
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
        }
    }
}