using System;

public class MathOperations
{
    // Method to add two integers
    public int Addition(int a, int b)
    {
        return a + b;
    }

    // Overloaded method to add two doubles
    public double Addition(double a, double b)
    {
        return a + b;
    }
}

public class Program
{
    static void Main()
    {
        MathOperations ops = new MathOperations();

        Console.WriteLine(ops.Addition(22, 34));           // Calls the first Add method
        //Console.WriteLine(math.Addition(2, 3, 4));        // Calls the second Add method
        Console.WriteLine(ops.Addition(2.512, 3.71386));       // Calls the third Add method
    }
}
