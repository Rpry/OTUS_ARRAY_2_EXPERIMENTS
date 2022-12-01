namespace Array2;

public static class CallStack
{
    public static string Method1(string s)
    {
        return Method2(s);
    }

    private static string Method2(string s)
    {
        return Method3(s);
    }
    
    private static string Method3(string s)
    {
        return s;
    }
}