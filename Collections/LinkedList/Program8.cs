using System;

class TextState
{
    public string Text;
    public TextState Next;
    public TextState Prev;

    public TextState(string text)
    {
        Text = text;
    }
}

class TextEditor
{
    private TextState head;
    private TextState tail;
    private TextState current;

    private const int MaxHistory = 10;
    private int count = 0;

    public TextEditor()
    {
        AddState("");
    }

    public void AddState(string text)
    {
        // Remove states after current when a new action is performed.
        if (current != tail)
        {
            TextState temp = current.Next;

            while (temp != null)
            {
                temp = temp.Next;
                count--;
            }

            current.Next = null;
            tail = current;
        }

        TextState newState = new TextState(text);

        if (head == null)
        {
            head = tail = current = newState;
            count = 1;
            return;
        }

        tail.Next = newState;
        newState.Prev = tail;
        tail = newState;
        current = newState;
        count++;

        // Keep only the latest 10 states.
        while (count > MaxHistory)
        {
            head = head.Next;
            head.Prev = null;
            count--;
        }
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Undo successful.");
        }
        else
        {
            Console.WriteLine("Nothing to undo.");
        }
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Redo successful.");
        }
        else
        {
            Console.WriteLine("Nothing to redo.");
        }
    }

    public void DisplayCurrent()
    {
        if (current == null)
            Console.WriteLine("Empty");
        else
            Console.WriteLine("Current Text: " + current.Text);
    }

    public void DisplayHistory()
    {
        TextState temp = head;

        Console.WriteLine("\nHistory:");

        while (temp != null)
        {
            if (temp == current)
                Console.WriteLine("-> " + temp.Text);
            else
                Console.WriteLine("   " + temp.Text);

            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();

        editor.AddState("Hello");
        editor.AddState("Hello World");
        editor.AddState("Hello World!");
        editor.AddState("Hello World! Welcome");

        editor.DisplayCurrent();

        editor.Undo();
        editor.DisplayCurrent();

        editor.Undo();
        editor.DisplayCurrent();

        editor.Redo();
        editor.DisplayCurrent();

        editor.DisplayHistory();
    }
}