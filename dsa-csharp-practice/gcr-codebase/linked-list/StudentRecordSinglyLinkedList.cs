using System;

class StudentNode
{
    public int RollNumber;
    public string Name;
    public int Age;
    public string Grade;
    public StudentNode Next;

    public StudentNode(int roll, string name, int age, string grade)
    {
        RollNumber = roll;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentLinkedList
{
    private StudentNode head;

    public void AddAtBeginning(int roll, string name, int age, string grade)
    {
        StudentNode newNode = new StudentNode(roll, name, age, grade);
        newNode.Next = head;
        head = newNode;
    }

    public void AddAtEnd(int roll, string name, int age, string grade)
    {
        StudentNode newNode = new StudentNode(roll, name, age, grade);

        if (head == null)
        {
            head = newNode;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    public void AddAtPosition(int roll, string name, int age, string grade, int position)
    {
        if (position <= 1)
        {
            AddAtBeginning(roll, name, age, grade);
            return;
        }

        StudentNode newNode = new StudentNode(roll, name, age, grade);
        StudentNode temp = head;

        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            AddAtEnd(roll, name, age, grade);
            return;
        }

        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    public void DeleteByRollNumber(int roll)
    {
        if (head == null)
            return;

        if (head.RollNumber == roll)
        {
            head = head.Next;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null && temp.Next.RollNumber != roll)
        {
            temp = temp.Next;
        }

        if (temp.Next != null)
        {
            temp.Next = temp.Next.Next;
        }
    }

    public StudentNode SearchByRollNumber(int roll)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.RollNumber == roll)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void UpdateGrade(int roll, string newGrade)
    {
        StudentNode student = SearchByRollNumber(roll);
        if (student != null)
        {
            student.Grade = newGrade;
        }
    }

    public void DisplayAll()
    {
        StudentNode temp = head;
        while (temp != null)
        {
            Console.WriteLine("Roll No : " + temp.RollNumber);
            Console.WriteLine("Name    : " + temp.Name);
            Console.WriteLine("Age     : " + temp.Age);
            Console.WriteLine("Grade   : " + temp.Grade);
            Console.WriteLine("-------------------------");
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentLinkedList list = new StudentLinkedList();

        list.AddAtBeginning(1, "Rahul", 20, "A");
        list.AddAtEnd(2, "Anita", 21, "B");
        list.AddAtPosition(3, "Karan", 19, "A", 2);

        list.DisplayAll();

        list.UpdateGrade(2, "A+");
        list.DeleteByRollNumber(1);

        Console.WriteLine("After Update and Delete");
        list.DisplayAll();

        Console.ReadLine();
    }
}
