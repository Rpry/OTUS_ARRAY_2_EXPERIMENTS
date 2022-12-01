namespace Array2;

public static class QueueExperiments
{
    public static void Do()
    {
        var queue = new Queue<string>();
        queue.Enqueue("one");
        var current = queue.Peek();
        queue.Enqueue("two");
        var last = queue.Dequeue();
        last = queue.Dequeue();
    }
}