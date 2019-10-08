<Query Kind="Program" />

void Main()
{
    Fib(100).Dump();    
    var testArray = new[] {1, 2, 3, 5, -1, 7, 145, -33, 22, 14};
    SeekClosestToAverage(testArray).Dump();
}

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
