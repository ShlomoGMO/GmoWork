<Query Kind="Program" />

void Main()
{
    Fib(100).Dump();    
    var testArray = new[] {1, 2, 3, 5, -1, 7, 145, -33, 22, 14};
    SeekClosestToAverage(testArray).Dump();
    var x = new int[,] {
        {4, 7, 12, 23, 27, 34, },
        {6, 10, 15, 24, 30, 40, },
        {12, 15, 18, 29, 32, 48, },
        {14, 18, 21, 30, 35, 54, },
        {20, 23, 24, 35, 37, 62, },
        {22, 27, 29, 39, 40, 68, },
        {28, 32, 33, 44, 46, 76, },
        {30, 36, 38, 48, 49, 82, },
    };
    SeekSortedDataStructure(x, 3).Dump();
    SeekSortedDataStructure(x, 4).Dump();
    SeekSortedDataStructure(x, 18).Dump();
    SeekSortedDataStructure(x, 26).Dump();
    SeekSortedDataStructure(x, 30).Dump();
    SeekSortedDataStructure(x, 34).Dump();
    SeekSortedDataStructure(x, 82).Dump();
    SeekSortedDataStructure(x, 83).Dump();
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

public bool SeekSortedDataStructure(int[,] array, int numToFind)
{
    var m = array.GetUpperBound(0);
    var n = array.GetUpperBound(1);
    if (m == 0 || n == 0)
        return false;
        
    return SeekSortedDataStructure(array, numToFind, 0);
}

public bool SeekSortedDataStructure(int[,] array, int numToFind, int column)
{
    if(column > array.GetUpperBound(0))
        return false;
    if(array[column, 0] > numToFind)
        return false;
        
    for(int i = 0; i <= array.GetUpperBound(1); i++)
    {
        if(array[column, i] == numToFind)
            return true;
        if(array[column, i] > numToFind)
            return SeekSortedDataStructure(array, numToFind, column + 1);
    }
    return SeekSortedDataStructure(array, numToFind, column + 1);
}