using System;
using System.Collections.Generic;

class SortStack
{
    static void Sort(Stack<int> st)
    {
        if (st.Count == 0)
            return;

        int x = st.Pop();
        Sort(st);
        Insert(st, x);
    }

    static void Insert(Stack<int> st, int x)
    {
        if (st.Count == 0 || st.Peek() <= x)
        {
            st.Push(x);
            return;
        }

        int temp = st.Pop();
        Insert(st, x);
        st.Push(temp);
    }

    static void Main()
    {
        Stack<int> st = new Stack<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
            st.Push(int.Parse(Console.ReadLine()));

        Sort(st);

        Console.WriteLine("Sorted Stack:");
        while (st.Count > 0)
            Console.Write(st.Pop() + " ");
    }
}
