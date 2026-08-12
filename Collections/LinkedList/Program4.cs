using System;

class Item
{
    public string Name;
    public int ID;
    public int Quantity;
    public double Price;
    public Item Next;

    public Item(string name, int id, int quantity, double price)
    {
        Name = name;
        ID = id;
        Quantity = quantity;
        Price = price;
    }
}

class Inventory
{
    private Item head;

    public void AddBeginning(string name, int id, int quantity, double price)
    {
        Item n = new Item(name, id, quantity, price);
        n.Next = head;
        head = n;
    }

    public void AddEnd(string name, int id, int quantity, double price)
    {
        Item n = new Item(name, id, quantity, price);

        if (head == null)
        {
            head = n;
            return;
        }

        Item temp = head;

        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = n;
    }

    public void AddAtPosition(int pos, string name, int id,
                              int quantity, double price)
    {
        if (pos <= 1)
        {
            AddBeginning(name, id, quantity, price);
            return;
        }

        Item temp = head;

        for (int i = 1; i < pos - 1 && temp != null; i++)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        Item n = new Item(name, id, quantity, price);
        n.Next = temp.Next;
        temp.Next = n;
    }

    public void Remove(int id)
    {
        if (head == null) return;

        if (head.ID == id)
        {
            head = head.Next;
            return;
        }

        Item temp = head;

        while (temp.Next != null && temp.Next.ID != id)
            temp = temp.Next;

        if (temp.Next != null)
            temp.Next = temp.Next.Next;
    }

    public void UpdateQuantity(int id, int quantity)
    {
        Item item = SearchByID(id);

        if (item != null)
            item.Quantity = quantity;
        else
            Console.WriteLine("Item not found.");
    }

    public Item SearchByID(int id)
    {
        Item temp = head;

        while (temp != null)
        {
            if (temp.ID == id)
                return temp;

            temp = temp.Next;
        }

        return null;
    }

    public void SearchByName(string name)
    {
        Item temp = head;

        while (temp != null)
        {
            if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                Print(temp);

            temp = temp.Next;
        }
    }

    public double TotalValue()
    {
        double total = 0;
        Item temp = head;

        while (temp != null)
        {
            total += temp.Price * temp.Quantity;
            temp = temp.Next;
        }

        return total;
    }

    public void SortByName(bool ascending)
    {
        for (Item i = head; i != null; i = i.Next)
        {
            for (Item j = i.Next; j != null; j = j.Next)
            {
                int comparison = string.Compare(i.Name, j.Name,
                    StringComparison.OrdinalIgnoreCase);

                if ((ascending && comparison > 0) ||
                    (!ascending && comparison < 0))
                {
                    Swap(i, j);
                }
            }
        }
    }

    public void SortByPrice(bool ascending)
    {
        for (Item i = head; i != null; i = i.Next)
        {
            for (Item j = i.Next; j != null; j = j.Next)
            {
                if ((ascending && i.Price > j.Price) ||
                    (!ascending && i.Price < j.Price))
                {
                    Swap(i, j);
                }
            }
        }
    }

    private void Swap(Item a, Item b)
    {
        string name = a.Name;
        int id = a.ID;
        int quantity = a.Quantity;
        double price = a.Price;

        a.Name = b.Name;
        a.ID = b.ID;
        a.Quantity = b.Quantity;
        a.Price = b.Price;

        b.Name = name;
        b.ID = id;
        b.Quantity = quantity;
        b.Price = price;
    }

    private void Print(Item i)
    {
        Console.WriteLine(
            $"ID: {i.ID}, Name: {i.Name}, Quantity: {i.Quantity}, Price: {i.Price:C}");
    }

    public void Display()
    {
        Item temp = head;

        while (temp != null)
        {
            Print(temp);
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        inventory.AddEnd("Laptop", 101, 5, 60000);
        inventory.AddBeginning("Mouse", 102, 20, 800);
        inventory.AddAtPosition(2, "Keyboard", 103, 10, 1500);

        Console.WriteLine("Inventory:");
        inventory.Display();

        Console.WriteLine($"\nTotal Inventory Value: {inventory.TotalValue():C}");

        inventory.UpdateQuantity(101, 8);

        Console.WriteLine("\nSorted by Price:");
        inventory.SortByPrice(true);
        inventory.Display();
    }
}