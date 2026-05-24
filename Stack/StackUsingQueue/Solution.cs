using System.Collections.Generic;
public class MyStack
{
    Queue<int> queue1, queue2;
    public MyStack()
    {
        queue1 = new Queue<int>();
        queue2 = new Queue<int>();
    }

    public void Push(int x)
    {
        if (queue1.Count == 0)
        {
            queue1.Enqueue(x);
        }
        else
        {
            while (queue1.Count > 0)
            {
                queue2.Enqueue(queue1.Dequeue());
            }
            queue1.Enqueue(x);
            while (queue2.Count > 0)
            {
                queue1.Enqueue(queue2.Dequeue());
            }
        }
    }

    public int Pop()
    {
        return queue1.Dequeue();
    }

    public int Top()
    {
        return queue1.Peek();
    }

    public bool Empty()
    {
        return (queue1.Count == 0);
    }
}