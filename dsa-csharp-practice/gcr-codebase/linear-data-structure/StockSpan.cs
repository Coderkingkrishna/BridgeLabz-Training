using System;
using System.Collections.Generic;

class StockSpan
{
    static void Main()
    {
        Console.Write("Enter number of days: ");
        int n = int.Parse(Console.ReadLine());

        int[] price = new int[n];
        int[] span = new int[n];
        Stack<int> st = new Stack<int>();

        for (int i = 0; i < n; i++)
            price[i] = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            while (st.Count > 0 && price[st.Peek()] <= price[i])
                st.Pop();

            span[i] = (st.Count == 0) ? i + 1 : i - st.Peek();
            st.Push(i);
        }

        Console.WriteLine("Stock Span:");
        for (int i = 0; i < n; i++)
            Console.Write(span[i] + " ");
    }
}
