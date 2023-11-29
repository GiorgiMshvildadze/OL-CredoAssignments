using System;

namespace NthFibonacci;

class Program
{
    public static long CalculateFibonacci(int n)
    {
        int a = 0;
        int b = 1;
        int c = 0;
        List<int> Fibonacci = new List<int>();

        Fibonacci.Add(a);
        Fibonacci.Add(b);
        for (int i = 0; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
            Fibonacci.Add(c);

        }
        return Fibonacci[n - 1];

    }
    static void Main(string[] args)
    {
        Console.WriteLine(CalculateFibonacci(Convert.ToInt32(Console.ReadLine()));
    }
}