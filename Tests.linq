<Query Kind="Program" />

void Main()
{
    Fib(100).Dump();    
    var testArray = new[] {1, 2, 3, 5, -1, 7, 145, -33, 22, 14};
    SeekClosestToAverage(testArray).Dump();
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
    if(fibIndex <= 0)
        throw new Exception("fibIndex must be greater than zero");
        
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

//#7 – Seek Closest to Average
//Create a method that, given an array of integers, will select the integer in the array that is the closest to the average of all integers in the array.
//•	The method takes one parameter, the array of integers, and returns the value from the array that is the closest to the average.
//•	If more than one integer is the closest, then any of the closest integers will do.
//•	For example, which integer in the array is the closest to the average given the following values in an array:  1, 2, 3, 5, -1, 7, 145, -33, 22, 14

public int SeekClosestToAverage(int[] array)
{
    if(array.Length == 0)
        throw new Exception("Contents empty.");
        
    var average = array.Average();
    int closest = array[0];
    double closestDiff = Math.Abs(closest - average);
    
    for (int i = 1; i < array.Length; i++)
    {
        var localNum = array[i];
        var localDiff = Math.Abs(localNum - average);
        if(localDiff < closestDiff)
        {
            closest = localNum;
            closestDiff = localDiff;
        }
    }
    return closest;
}
