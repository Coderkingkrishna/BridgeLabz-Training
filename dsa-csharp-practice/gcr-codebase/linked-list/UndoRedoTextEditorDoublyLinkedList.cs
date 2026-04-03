using System;

class TextStateNode
{
    public string Content;
    public TextStateNode Prev;
    public TextStateNode Next;

    public TextStateNode(string content)
    {
        Content = content;
        Prev = null;
        Next = null;
    }
}

class TextEditorHistory
{
    private TextStateNode head;
    private TextStateNode tail;
    private TextStateNode current;
    private int size;
    private int limit;

    public TextEditorHistory(int maxSize)
    {
        limit = maxSize;
        size = 0;
    }

    public void AddState(string content)
    {
        TextStateNode newNode = new TextStateNode(content);

        if (head == null)
        {
            head = tail = current = newNode;
            size = 1;
            return;
        }

        current.Next = null;
        tail = current;

        tail.Next = newNode;
        newNode.Prev = tail;
        tail = newNode;
        current = newNode;
        size++;

        if (size > limit)
        {
            head = head.Next;
            head.Prev = null;
            size--;
        }
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
            current = current.Prev;
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
            current = current.Next;
    }

    public void DisplayCurrentState()
    {
        if (current != null)
            Console.WriteLine("Current Text: " + current.Content);
    }
}

class Program
{
    static void Main()
    {
        TextEditorHistory editor = new TextEditorHistory(10);

        editor.AddState("Hello");
        editor.AddState("Hello World");
        editor.AddState("Hello World!");

        editor.DisplayCurrentState();

        editor.Undo();
        editor.DisplayCurrentState();

        editor.Undo();
        editor.DisplayCurrentState();

        editor.Redo();
        editor.DisplayCurrentState();

        editor.AddState("Hello C#");
        editor.DisplayCurrentState();

        Console.ReadLine();
    }
}
