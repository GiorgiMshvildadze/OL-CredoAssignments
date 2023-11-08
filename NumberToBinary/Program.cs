using System;
using System.Linq;

namespace NumToBinary;




class Program
{

    static long ToBinary(long number)
    {

        string? ReverseBinary = null;
        string? Binary = null;
        while (number >= 1)
        {
            string smth = (number % 2).ToString();

            number = number / 2;

            ReverseBinary = ReverseBinary + smth;

        }
        foreach (char i in ReverseBinary)
        {
            Binary = i + Binary;

        }

        Console.WriteLine(Binary);
        return 0;
        
    }


    static void Main(string[] args)
    {
        ToBinary(1000);
        Console.ReadLine();
    }
}

