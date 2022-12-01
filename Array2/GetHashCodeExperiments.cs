namespace Array2;

public static class GetHashCodeExperiments
{
    public static void Do()
    {
        var obj = new object();
        Console.WriteLine(1.GetHashCode());
        Console.WriteLine(32.GetHashCode());
        Console.WriteLine(((long)Int32.MaxValue).GetHashCode());
        Console.WriteLine(((long)Int32.MaxValue + 1).GetHashCode());
        Console.WriteLine(obj.GetHashCode());

        obj.Equals(1);

        var trueHash = true.GetHashCode();
        var oneHash = 1.GetHashCode();
    }
}