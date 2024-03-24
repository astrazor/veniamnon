// Example of an inline method
public int Sum(int a, int b) => a + b;

// Example of using ref parameters for large structs
public int Sum(ref LargeStruct a, ref LargeStruct b)
{
    // Summation logic for large structs
}

// Example of using unchecked context
public int Sum(int a, int b)
{
    unchecked
    {
        return a + b;
    }
}
