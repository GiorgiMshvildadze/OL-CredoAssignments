using System;

namespace MultiplicationTable;

class Program
{
    static void Main(string[] args)
    {
        int input1 = Convert.ToInt32(Console.ReadLine());
        int input2 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= input1; i++)
        {
            Console.WriteLine("\n  ");
            for (int j = 1; j <= input2; j++)
            {
                Console.Write($"{i}x{j} = {i * j}   ");
            }

        }
    }
}