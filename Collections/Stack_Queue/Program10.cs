using System;

class MyHashMap
{
    class Node
    {
        public int Key;
        public int Value;
        public Node Next;

        public Node(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    private Node[] buckets;
    private int size;

    public MyHashMap(int size)
    {
        this.size = size;
        buckets = new Node[size];
    }

    private int GetIndex(int key)
    {
        return Math.Abs(key) % size;
    }

    public void Put(int key, int value)
    {
        int index = GetIndex(key);

        Node current = buckets[index];

        // Key already exists
        while (current != null)
        {
            if (current.Key == key)
            {
                current.Value = value;
                return;
            }

            current = current.Next;
        }

        // New node
        Node newNode = new Node(key, value);

        newNode.Next = buckets[index];
        buckets[index] = newNode;
    }

    public int Get(int key)
    {
        int index = GetIndex(key);

        Node current = buckets[index];

        while (current != null)
        {
            if (current.Key == key)
                return current.Value;

            current = current.Next;
        }

        return -1;
    }

    public void Remove(int key)
    {
        int index = GetIndex(key);

        Node current = buckets[index];
        Node previous = null;

        while (current != null)
        {
            if (current.Key == key)
            {
                if (previous == null)
                    buckets[index] = current.Next;
                else
                    previous.Next = current.Next;

                return;
            }

            previous = current;
            current = current.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        MyHashMap map = new MyHashMap(10);

        map.Put(1, 100);
        map.Put(2, 200);

        Console.WriteLine(map.Get(1)); // 100

        map.Put(1, 500);

        Console.WriteLine(map.Get(1)); // 500

        map.Remove(1);

        Console.WriteLine(map.Get(1)); // -1
    }
}