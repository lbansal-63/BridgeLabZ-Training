using System;

class Process
{
    public int ID;
    public int BurstTime;
    public int RemainingTime;
    public int Priority;

    public int CompletionTime;
    public int WaitingTime;
    public int TurnaroundTime;

    public Process Next;

    public Process(int id, int burst, int priority)
    {
        ID = id;
        BurstTime = burst;
        RemainingTime = burst;
        Priority = priority;
    }
}

class RoundRobin
{
    private Process head;
    private Process tail;

    public void AddProcess(int id, int burst, int priority)
    {
        Process p = new Process(id, burst, priority);

        if (head == null)
        {
            head = tail = p;
            p.Next = head;
        }
        else
        {
            p.Next = head;
            tail.Next = p;
            tail = p;
        }
    }

    public void RemoveProcess(int id)
    {
        if (head == null)
            return;

        Process current = head;
        Process previous = tail;

        do
        {
            if (current.ID == id)
            {
                if (current == head)
                    head = head.Next;

                if (current == tail)
                    tail = previous;

                previous.Next = current.Next;

                if (current == head && current == tail)
                    head = tail = null;

                return;
            }

            previous = current;
            current = current.Next;

        } while (current != head);
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No processes.");
            return;
        }

        Process temp = head;

        do
        {
            Console.WriteLine(
                $"P{temp.ID} | Burst: {temp.BurstTime} | " +
                $"Remaining: {temp.RemainingTime} | Priority: {temp.Priority}");

            temp = temp.Next;

        } while (temp != head);
    }

    public void Schedule(int quantum)
    {
        if (head == null)
            return;

        int currentTime = 0;
        int completed = 0;
        int processCount = Count();

        Process current = head;

        Console.WriteLine("\nRound Robin Execution:");

        while (completed < processCount)
        {
            if (current.RemainingTime > 0)
            {
                int executionTime =
                    Math.Min(quantum, current.RemainingTime);

                Console.WriteLine(
                    $"P{current.ID} executes for {executionTime} units.");

                current.RemainingTime -= executionTime;
                currentTime += executionTime;

                if (current.RemainingTime == 0)
                {
                    current.CompletionTime = currentTime;
                    current.TurnaroundTime = current.CompletionTime;
                    current.WaitingTime =
                        current.TurnaroundTime - current.BurstTime;

                    completed++;
                }
            }

            current = current.Next;

            Console.WriteLine("\nProcesses after round:");
            Display();
        }

        CalculateAverage();
    }

    private int Count()
    {
        int count = 0;

        Process temp = head;

        do
        {
            count++;
            temp = temp.Next;

        } while (temp != head);

        return count;
    }

    private void CalculateAverage()
    {
        double totalWaiting = 0;
        double totalTurnaround = 0;

        Process temp = head;

        do
        {
            totalWaiting += temp.WaitingTime;
            totalTurnaround += temp.TurnaroundTime;

            temp = temp.Next;

        } while (temp != head);

        int count = Count();

        Console.WriteLine("\nProcess Statistics:");

        temp = head;

        do
        {
            Console.WriteLine(
                $"P{temp.ID}: Waiting Time = {temp.WaitingTime}, " +
                $"Turnaround Time = {temp.TurnaroundTime}");

            temp = temp.Next;

        } while (temp != head);

        Console.WriteLine(
            $"\nAverage Waiting Time: {totalWaiting / count:F2}");

        Console.WriteLine(
            $"Average Turnaround Time: {totalTurnaround / count:F2}");
    }
}

class Program
{
    static void Main()
    {
        RoundRobin scheduler = new RoundRobin();

        scheduler.AddProcess(1, 5, 1);
        scheduler.AddProcess(2, 8, 2);
        scheduler.AddProcess(3, 4, 1);
        scheduler.AddProcess(4, 6, 3);

        Console.WriteLine("Initial Processes:");
        scheduler.Display();

        Console.Write("\nEnter Time Quantum: ");
        int quantum = int.Parse(Console.ReadLine());

        scheduler.Schedule(quantum);
    }
}