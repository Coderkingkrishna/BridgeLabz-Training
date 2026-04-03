class CustomStack
{
    private int[] stack;
    private int top;

    public CustomStack(int size)
    {
        stack = new int[size];
        top = -1;
    }

    public void Push(int value)
    {
        if (top == stack.Length - 1)
            return;

        stack[++top] = value;
    }

    public int Peek()
    {
        if (top == -1)
            return -1;

        return stack[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }
}
