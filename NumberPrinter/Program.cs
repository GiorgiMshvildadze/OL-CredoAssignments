using System;

namespace NumberPrinter;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(i);
        }

    }
}