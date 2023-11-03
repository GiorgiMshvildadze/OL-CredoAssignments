using System.Linq.Expressions;

namespace ArrayOperations;

class ArrayOperations
{

    //public static int[] array = new int[n];
    public static string input = Console.ReadLine();
    public static string[] array = input.Split(",");
    public static int[] numbers = new int[array.Length];
    public static int sum = 0;

    public static void InputNumbers()
    {
        Console.WriteLine("Enter Numbers Separated By Commas:");
        for (int i = 0; i < array.Length; i++)
        {
            if (Int32.TryParse(array[i], out var number))
            {
                numbers[i] = number;
            }
        }

    }

    public static int CalculateSum(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    public static double CalculateAverage(int[] array)
    {

        double average = (double)sum / (double)array.Length;

        return average;
    }

    public static int FindMax(int[] array)
    {
        Array.Sort(array);
        return array[array.Length - 1];

    }

    public static int FindMin(int[] array)
    {
        Array.Sort(array);
        return array[0];

    }


    static void Main(string[] args)
    {
        InputNumbers();

        Console.WriteLine(CalculateSum(numbers));
        Console.WriteLine(CalculateAverage(numbers));
        Console.WriteLine(FindMax(numbers));
        Console.WriteLine(FindMin(numbers));

    }
}