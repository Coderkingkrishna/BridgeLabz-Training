
public class StringUtils
{
    public string Reverse(string s)
    {
        char[] arr = s.ToCharArray();
        System.Array.Reverse(arr);
        return new string(arr);
    }

    public bool IsPalindrome(string s)
    {
        return s == Reverse(s);
    }

    public string ToUpperCase(string s)
    {
        return s.ToUpper();
    }
}
