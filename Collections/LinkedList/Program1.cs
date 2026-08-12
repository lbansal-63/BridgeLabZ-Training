using System;

class Student
{
    public int RollNo;
    public string Name;
    public int Age;
    public char Grade;
    public Student Next;

    public Student(int rollNo, string name, int age, char grade)
    {
        RollNo = rollNo;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentList
{
    private Student head;

    public void AddBeginning(int roll, string name, int age, char grade)
    {
        Student n = new Student(roll, name, age, grade);
        n.Next = head;
        head = n;
    }

    public void AddEnd(int roll, string name, int age, char grade)
    {
        Student n = new Student(roll, name, age, grade);

        if (head == null)
        {
            head = n;
            return;
        }

        Student temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = n;
    }

    public void AddAtPosition(int pos, int roll, string name, int age, char grade)
    {
        if (pos <= 1)
        {
            AddBeginning(roll, name, age, grade);
            return;
        }

        Student temp = head;

        for (int i = 1; i < pos - 1 && temp != null; i++)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        Student n = new Student(roll, name, age, grade);
        n.Next = temp.Next;
        temp.Next = n;
    }

    public void Delete(int roll)
    {
        if (head == null) return;

        if (head.RollNo == roll)
        {
            head = head.Next;
            return;
        }

        Student temp = head;

        while (temp.Next != null && temp.Next.RollNo != roll)
            temp = temp.Next;

        if (temp.Next != null)
            temp.Next = temp.Next.Next;
        else
            Console.WriteLine("Student not found.");
    }

    public Student Search(int roll)
    {
        Student temp = head;

        while (temp != null)
        {
            if (temp.RollNo == roll)
                return temp;

            temp = temp.Next;
        }

        return null;
    }

    public void UpdateGrade(int roll, char grade)
    {
        Student student = Search(roll);

        if (student == null)
            Console.WriteLine("Student not found.");
        else
            student.Grade = grade;
    }

    public void Display()
    {
        Student temp = head;

        while (temp != null)
        {
            Console.WriteLine(
                $"Roll: {temp.RollNo}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");

            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentList list = new StudentList();

        list.AddBeginning(101, "Rahul", 20, 'A');
        list.AddEnd(102, "Aman", 21, 'B');
        list.AddAtPosition(2, 103, "Priya", 20, 'A');

        Console.WriteLine("Students:");
        list.Display();

        Console.WriteLine("\nSearching Roll No 102:");
        Student s = list.Search(102);

        if (s != null)
            Console.WriteLine($"{s.Name} - Grade {s.Grade}");

        list.UpdateGrade(102, 'A');
        list.Delete(101);

        Console.WriteLine("\nAfter update and deletion:");
        list.Display();
    }
}