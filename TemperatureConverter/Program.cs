using System;

namespace TempConverter;

class Program
{


    static void Main(string[] args)
    {
        decimal Temperature;




        while (true)
        {
            try
            {
                Console.WriteLine("Enter Temperature in C:");
                Temperature = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine( Temperature * 9 / 5 + 32);
                Console.WriteLine("Enter Temperature in F: ");
                Temperature = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine((Temperature - 32) * 5 / 9);
            }
            catch
            {
                Console.WriteLine("Please enter valid number:");
            }
        }






    }
}