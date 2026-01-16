using System;

class TabHistory
{
    private PageNode head;
    private PageNode current;

    public void Visit(string url)
    {
        PageNode newPage = new PageNode(url);

        if (head == null)
        {
            head = newPage;
            current = newPage;
            return;
        }

        // Clear forward history
        current.Next = null;

        newPage.Prev = current;
        current.Next = newPage;
        current = newPage;
    }

    public void Back()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Back to: " + current.Url);
        }
        else
        {
            Console.WriteLine("No previous page.");
        }
    }

    public void Forward()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Forward to: " + current.Url);
        }
        else
        {
            Console.WriteLine("No forward page.");
        }
    }

    public string GetCurrentPage()
    {
        return current != null ? current.Url : "Empty Tab";
    }

    public void DisplayHistory()
    {
        PageNode temp = head;
        Console.Write("History: ");
        while (temp != null)
        {
            if (temp == current)
                Console.Write("[" + temp.Url + "] ");
            else
                Console.Write(temp.Url + " ");

            temp = temp.Next;
        }
        Console.WriteLine();
    }
}
