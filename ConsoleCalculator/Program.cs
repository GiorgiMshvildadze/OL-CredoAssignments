using System;

namespace smth;

class Program
{

    public static int Num1;
    public static int Num2;
    public static string mathOp;
    public static double answer;

    //funciotns
    static void Addition()
    {
        answer = Num1 + Num2;
    }
    static void Subtraction()
    {
        answer = Num1 - Num2;
    }

    static void Multiplication()
    {
        answer = Num1 * Num2;
    }

    static void division()
    {
        answer = Convert.ToDouble(Num1) / Num2;
    }
    static void Main(string[] args)
    {

        bool keepGoing = true;


        while (keepGoing)
        {
            Console.WriteLine("Enter first number:");          //entering num1
            if (!int.TryParse(Console.ReadLine(), out Num1))    //checking if num1 is int, if not throwing error
            {
                Console.WriteLine("Invalid input. Please enter a number: ");  // error message
                continue;
            }

            Console.WriteLine("Enter second Number: ");         //entering num2
            if (!int.TryParse(Console.ReadLine(), out Num2))     //checking if num2 is int, if not throwing error         
            {
                Console.WriteLine("Invalid input. Please enter a number: ");  //error message
                continue;
            }

            Console.WriteLine("Enter math operator: ");
            mathOp = Console.ReadLine();  // entering operator
            //doing operation
            switch (mathOp)
            {
                case "+":
                    Addition();
                    break;
                case "-":
                    Subtraction();
                    break;
                case "*":
                    Multiplication();
                    break;
                case "/":
                    division();
                    break;
                default:
                    break;
            }

            if (mathOp == "/" && Num2 == 0)// cannot divide by zero exception
            {
                Console.WriteLine("Cannot divide by 0. Please try again.");
                continue;
            }

            Console.WriteLine("Answer is: " + answer + "\n \n");
        }
    }
}
