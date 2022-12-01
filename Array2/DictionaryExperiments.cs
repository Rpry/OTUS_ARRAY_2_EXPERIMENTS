namespace Array2;

public static class DictionaryExperiments
{
    public static void Do()
    {
        var dict = new Dictionary<string, string>();
        dict.Add("table", "стол");
        dict.Add("chair", "стул");
        Console.WriteLine(dict["table"]);
    }
}