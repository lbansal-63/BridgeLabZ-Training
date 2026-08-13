using System;
using System.Collections.Generic;

class MyQueue
{
    Stack<int> stack1 = new Stack<int>();
    Stack<int> stack2 = new Stack<int>();

    public void Enqueue(int value)
    {
        stack1.Push(value);
    }

    public int Dequeue()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
                stack2.Push(stack1.Pop());
        }

        if (stack2.Count == 0)
            throw new InvalidOperationException("Queue is empty");

        return stack2.Pop();
    }

    public int Peek()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
                stack2.Push(stack1.Pop());
        }

        return stack2.Peek();
    }
}