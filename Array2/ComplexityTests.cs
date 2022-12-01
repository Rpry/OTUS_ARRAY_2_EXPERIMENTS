using System.Diagnostics;
using AutoFixture;

namespace Array2;

public class ComplexityTests
{
    private IEnumerable<string> shortArray;
    private IEnumerable<string> middleArray;
    private IEnumerable<string> longArray;
    private string newItem = "newItem";

    public ComplexityTests()
    {
        Fixture autoFixture = new Fixture();

        autoFixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
            .ForEach(b => autoFixture.Behaviors.Remove(b));
        autoFixture.Behaviors.Add(new OmitOnRecursionBehavior());

        shortArray = autoFixture.CreateMany<string>(1);
        middleArray = autoFixture.CreateMany<string>(500000);
        longArray = autoFixture.CreateMany<string>(1000000);
    }
        
    public async Task Queue_CleanAll()
    {
        DequeueAll(new Queue<string>(), false);
        
        var shortQueue = new Queue<string>(shortArray);
        DequeueAll(shortQueue);
        
        var middleQueue = new Queue<string>(middleArray);
        DequeueAll(middleQueue);
        
        var longQueue = new Queue<string>(longArray);
        DequeueAll(longQueue);
    }
    
    public async Task Queue_AddElement()
    {
        AddElementToQueue(new Queue<string>(), String.Empty, false);
        
        var shortQueue = new Queue<string>(shortArray);
        AddElementToQueue(shortQueue, newItem);
        
        var middleQueue = new Queue<string>(middleArray);
        AddElementToQueue(middleQueue, newItem);
        
        var longQueue = new Queue<string>(longArray);
        AddElementToQueue(longQueue, newItem);
    }
    
    public async Task Stack_CleanAll()
    {
        CleanAll(new Stack<string>(), false);

        var shortStack = new Stack<string>(shortArray);
        CleanAll(shortStack);
        
        var middleStack = new Stack<string>(middleArray);
        CleanAll(middleStack);
        
        var longStack = new Stack<string>(longArray);
        CleanAll(longStack);
    }
    
    public async Task Stack_AddElement()
    {
        AddElementToStack(new Stack<string>(), String.Empty, false);

        var shortStack = new Stack<string>(shortArray);
        AddElementToStack(shortStack, newItem);
        
        var middleStack = new Stack<string>(middleArray);
        AddElementToStack(middleStack, newItem);
        
        var longStack = new Stack<string>(longArray);
        AddElementToStack(longStack, newItem);
    }

    private void DequeueAll(Queue<string> queue, bool loggingEnabled = true)
    {
        RunWithStopwatch(() =>
        {
            while (queue.Count != 0)
            {
                queue.Dequeue();    
            }
        },
        loggingEnabled);
    }
    
    private void CleanAll(Stack<string> stack, bool loggingEnabled = true)
    {
        RunWithStopwatch(() =>
        {
            while (stack.Count != 0)
            {
                stack.Pop();    
            }
        },
        loggingEnabled);
    }

    private void AddElementToQueue(Queue<string> queue, string newElement, bool loggingEnabled = true)
    {
        RunWithStopwatch(() =>
        {
            queue.Enqueue(newElement);
        },
        loggingEnabled);
    }
    
    private void AddElementToStack(Stack<string> stack, string newElement, bool loggingEnabled = true)
    {
        RunWithStopwatch(() =>
        {
            stack.Push(newElement);
        },
        loggingEnabled);
    }
    
    private void RunWithStopwatch(Action action, bool loggingEnabled)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        action();
        stopwatch.Stop();
        if (loggingEnabled)
        {
            Console.WriteLine(stopwatch.Elapsed);    
        }
    }
}