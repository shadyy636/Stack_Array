using System;

namespace StackArray
{
    class StackArray
    {
        int[] dataArray;
        public int top;
        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            return false;
        }
        public bool IsFull()
        {
            if(top == dataArray.Length - 1)
            {
                return false;
            }
            return true;
        }
        public StackArray(int size)
        {
            if (size <= 0) size = 1;

            dataArray = new int[size];
            top = -1;
        }
        public void Push(int data)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                dataArray[++top] = data;
            }
        }

        public void Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            else
            {
                Console.WriteLine("Value has popped: " + dataArray[top--]);
            }
        }
        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            else
            {
                Console.WriteLine("Top element is: " + dataArray[top]);
            }
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow!");
                return;
            }
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(dataArray[i]);
                }
            }
        }
        public void Clear()
        {
            top = -1;
            Console.WriteLine("Stack is empty");
        }

    }
     class Program
    {
        static void Main(string[] args)
        {
          StackArray myStack = new StackArray(5);
            myStack.Push(5);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Pop();
            myStack.Peek();
            myStack.Display();
        }
    }
}
