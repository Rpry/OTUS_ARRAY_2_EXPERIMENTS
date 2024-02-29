namespace Array2;

public static class HashSetExperiments
{
    public static void Do()
    {
        var hash1 = new HashSet<int>();
        hash1.Add(1);
        hash1.Add(1);
        hash1.Add(3);
        //hash1.Remove(1);

        var hash2 = new HashSet<int>();
        hash2.Add(10);
        hash2.Add(6);
        hash2.Add(1);

        var intersect = hash1.Intersect(hash2).ToList();
        var union = hash1.Union(hash2).ToList();
        var except = hash1.Except(hash2).ToList();

        Console.WriteLine(hash2.Contains(1));
        
        var hash3 = new HashSet<Person>(Person.NameComparer);
        hash3.Add(new Person() { Name = "Ivan" });
        hash3.Add(new Person() { Name = "Petr" });
        hash3.Add(new Person() { Name = "Ivan" });
        
        Console.WriteLine(hash3.Contains(new Person() { Name = "Petr" }));
    }
}