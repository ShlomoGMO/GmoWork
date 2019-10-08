<Query Kind="Program" />

void Main()
{
    Fib(100).Dump();    
}

// Define other methods and classes here
//#6 – Fibonacci Numbers
//Create a method that will find a value from the sequence of the Fibonacci numbers at a specific index.
//•	The method takes one parameter, the index, and returns the value for that index.
//•	Find the 100th value in the sequence of the Fibonacci numbers.
//o   Hint: The value of the 100th Fibonacci number is 354, 224, 848, 179, 261, 915, 075.
//

public decimal Fib(int fibIndex) 
{
    var initialDict = new Dictionary<int, decimal> {
        {1, 1m},
        {2, 1m},
    };
    return RecursiveFib(fibIndex, initialDict);
}

public decimal RecursiveFib(int fibIndex, Dictionary<int, decimal> history)
{
    if(!history.ContainsKey(fibIndex))
    {
        var b = RecursiveFib(fibIndex - 2, history);
        var a = RecursiveFib(fibIndex - 1, history);
        history[fibIndex] = a + b;
    }
    return history[fibIndex];
}