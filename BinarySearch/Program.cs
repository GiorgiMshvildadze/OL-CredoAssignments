using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BinarySearch;

class Program
{
    public static int BinarySearch(int[] array, int target)
    {
        int j = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                j = i;
                return j;
            }
        }
        return -1;
    }
    static void Main(string[] args)
    {
        var array = new int[] { 5, 7, 19, 123, 134, 528 };
        var target = 527;
        Console.WriteLine(BinarySearch(array, target));
    }
}