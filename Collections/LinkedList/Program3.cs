using System;

class TaskNode
{
    public int TaskID;
    public string TaskName;
    public int Priority;
    public string DueDate;
    public TaskNode Next;

    public TaskNode(int id, string name, int priority, string dueDate)
    {
        TaskID = id;
        TaskName = name;
        Priority = priority;
        DueDate = dueDate;
    }
}

class TaskScheduler
{
    private TaskNode head;
    private TaskNode tail;
    private TaskNode current;

    public void AddBeginning(int id, string name, int priority, string dueDate)
    {
        TaskNode n = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = tail = n;
            n.Next = head;
        }
        else
        {
            n.Next = head;
            head = n;
            tail.Next = head;
        }

        if (current == null)
            current = head;
    }

    public void AddEnd(int id, string name, int priority, string dueDate)
    {
        TaskNode n = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = tail = n;
            n.Next = head;
            current = head;
        }
        else
        {
            n.Next = head;
            tail.Next = n;
            tail = n;
        }
    }

    public void AddAtPosition(int pos, int id, string name,
                              int priority, string dueDate)
    {
        if (pos <= 1)
        {
            AddBeginning(id, name, priority, dueDate);
            return;
        }

        if (head == null)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        TaskNode temp = head;

        for (int i = 1; i < pos - 1; i++)
        {
            temp = temp.Next;

            if (temp == head)
            {
                Console.WriteLine("Invalid position.");
                return;
            }
        }

        TaskNode n = new TaskNode(id, name, priority, dueDate);
        n.Next = temp.Next;
        temp.Next = n;

        if (temp == tail)
            tail = n;
    }

    public void Remove(int id)
    {
        if (head == null) return;

        TaskNode currentNode = head;
        TaskNode previous = tail;

        do
        {
            if (currentNode.TaskID == id)
            {
                if (currentNode == head)
                    head = head.Next;

                if (currentNode == tail)
                    tail = previous;

                previous.Next = currentNode.Next;

                if (currentNode == head && currentNode == tail)
                    head = tail = null;

                if (current == currentNode)
                    current = head;

                return;
            }

            previous = currentNode;
            currentNode = currentNode.Next;

        } while (currentNode != head);

        Console.WriteLine("Task not found.");
    }

    public void ViewCurrent()
    {
        if (current == null)
        {
            Console.WriteLine("No tasks.");
            return;
        }

        Print(current);
    }

    public void MoveNext()
    {
        if (current != null)
        {
            current = current.Next;
            Console.WriteLine("Moved to next task:");
            Print(current);
        }
    }

    public void SearchPriority(int priority)
    {
        if (head == null) return;

        TaskNode temp = head;

        do
        {
            if (temp.Priority == priority)
                Print(temp);

            temp = temp.Next;

        } while (temp != head);
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks.");
            return;
        }

        TaskNode temp = head;

        do
        {
            Print(temp);
            temp = temp.Next;
        } while (temp != head);
    }

    private void Print(TaskNode t)
    {
        Console.WriteLine(
            $"ID: {t.TaskID}, Name: {t.TaskName}, Priority: {t.Priority}, Due: {t.DueDate}");
    }
}

class Program
{
    static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();

        scheduler.AddBeginning(1, "Study", 2, "15-08-2026");
        scheduler.AddEnd(2, "Assignment", 1, "16-08-2026");
        scheduler.AddEnd(3, "Project", 3, "20-08-2026");

        Console.WriteLine("All Tasks:");
        scheduler.Display();

        Console.WriteLine("\nCurrent Task:");
        scheduler.ViewCurrent();

        scheduler.MoveNext();

        Console.WriteLine("\nPriority 1 tasks:");
        scheduler.SearchPriority(1);

        scheduler.Remove(2);
    }
}