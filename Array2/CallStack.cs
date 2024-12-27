namespace Array2;

public static class CallStack
{
    public static void Method1()
    {
        //Code before
        Method2();
        //Code after
    }

    private static void Method2()
    {
        //Code before
        Method3();
        //Code after
    }
    
    private static void Method3()
    {
        //Code
    }
}