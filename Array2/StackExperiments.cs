namespace Array2;

public static class StackExperiments
{
    public static void Do()
    {
        var stack = new Stack<string>();
        stack.Push("one");
        var current = stack.Peek();
        stack.Push("two");
        var last = stack.Pop();
        last = stack.Pop();
    }
}