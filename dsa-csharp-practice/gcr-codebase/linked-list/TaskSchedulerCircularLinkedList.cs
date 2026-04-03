using System;

class TaskNode
{
    public int TaskId;
    public string TaskName;
    public int Priority;
    public string DueDate;
    public TaskNode Next;

    public TaskNode(int id, string name, int priority, string dueDate)
    {
        TaskId = id;
        TaskName = name;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

class TaskCircularLinkedList
{
    private TaskNode head;
    private TaskNode current;

    public void AddTask(int id, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            current = head;
            return;
        }

        TaskNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newNode;
        newNode.Next = head;
    }

    public void RemoveTask(int id)
    {
        if (head == null)
            return;

        TaskNode temp = head;
        TaskNode prev = null;

        do
        {
            if (temp.TaskId == id)
            {
                if (prev != null)
                    prev.Next = temp.Next;
                else
                {
                    TaskNode last = head;
                    while (last.Next != head)
                        last = last.Next;

                    head = temp.Next;
                    last.Next = head;
                }
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);
    }

    public void ViewCurrentTask()
    {
        if (current == null)
            return;

        PrintTask(current);
        current = current.Next;
    }

    public void DisplayAllTasks()
    {
        if (head == null)
            return;

        TaskNode temp = head;
        do
        {
            PrintTask(temp);
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchByPriority(int priority)
    {
        if (head == null)
            return;

        TaskNode temp = head;
        do
        {
            if (temp.Priority == priority)
                PrintTask(temp);
            temp = temp.Next;
        } while (temp != head);
    }

    private void PrintTask(TaskNode task)
    {
        Console.WriteLine("Task ID   : " + task.TaskId);
        Console.WriteLine("Name      : " + task.TaskName);
        Console.WriteLine("Priority  : " + task.Priority);
        Console.WriteLine("Due Date  : " + task.DueDate);
        Console.WriteLine("--------------------------");
    }
}

class Program
{
    static void Main()
    {
        TaskCircularLinkedList scheduler = new TaskCircularLinkedList();

        scheduler.AddTask(1, "Design Module", 1, "10-02-2026");
        scheduler.AddTask(2, "Code Review", 2, "12-02-2026");
        scheduler.AddTask(3, "Testing", 1, "15-02-2026");

        scheduler.DisplayAllTasks();

        Console.WriteLine("Current Task Execution:");
        scheduler.ViewCurrentTask();
        scheduler.ViewCurrentTask();

        Console.WriteLine("Search Priority 1 Tasks:");
        scheduler.SearchByPriority(1);

        scheduler.RemoveTask(2);

        Console.WriteLine("After Removal:");
        scheduler.DisplayAllTasks();

        Console.ReadLine();
    }
}
