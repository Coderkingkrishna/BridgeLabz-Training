
public class Divider
{
    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new System.ArithmeticException();
        return a / b;
    }
}
