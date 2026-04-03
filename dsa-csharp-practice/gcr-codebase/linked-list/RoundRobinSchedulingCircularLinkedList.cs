using System;

class ProcessNode
{
    public int ProcessId;
    public int BurstTime;
    public int RemainingTime;
    public int Priority;
    public ProcessNode Next;

    public ProcessNode(int id, int burst, int priority)
    {
        ProcessId = id;
        BurstTime = burst;
        RemainingTime = burst;
        Priority = priority;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private ProcessNode head;
    private int timeQuantum;

    public RoundRobinScheduler(int quantum)
    {
        timeQuantum = quantum;
    }

    public void AddProcess(int id, int burst, int priority)
    {
        ProcessNode newNode = new ProcessNode(id, burst, priority);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            return;
        }

        ProcessNode temp = head;
        while (temp.Next != head)
            temp = temp.Next;

        temp.Next = newNode;
        newNode.Next = head;
    }

    public void Execute()
    {
        if (head == null)
            return;

        ProcessNode temp = head;
        int time = 0;
        int completed = 0;
        int totalWaiting = 0;
        int totalTurnAround = 0;

        do
        {
            if (temp.RemainingTime > 0)
            {
                int executed = temp.RemainingTime > timeQuantum ? timeQuantum : temp.RemainingTime;
                temp.RemainingTime -= executed;
                time += executed;

                if (temp.RemainingTime == 0)
                {
                    completed++;
                    int turnaround = time;
                    int waiting = turnaround - temp.BurstTime;
                    totalWaiting += waiting;
                    totalTurnAround += turnaround;
                }
            }
            temp = temp.Next;
        } while (completed < CountProcesses());

        Console.WriteLine("Average Waiting Time: " + (double)totalWaiting / CountProcesses());
        Console.WriteLine("Average Turnaround Time: " + (double)totalTurnAround / CountProcesses());
    }

    public void DisplayProcesses()
    {
        if (head == null)
            return;

        ProcessNode temp = head;
        do
        {
            Console.WriteLine("Process ID: " + temp.ProcessId + " Remaining Time: " + temp.RemainingTime);
            temp = temp.Next;
        } while (temp != head);
    }

    private int CountProcesses()
    {
        int count = 0;
        ProcessNode temp = head;
        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);
        return count;
    }
}

class Program
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler(4);

        scheduler.AddProcess(1, 10, 1);
        scheduler.AddProcess(2, 5, 2);
        scheduler.AddProcess(3, 8, 1);

        scheduler.DisplayProcesses();

        scheduler.Execute();

        Console.ReadLine();
    }
}
