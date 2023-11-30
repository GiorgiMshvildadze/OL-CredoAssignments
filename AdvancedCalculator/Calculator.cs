using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculator
{
    public class Calculator
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Result { get; set; }
        int option;
     
        public Calculator()
        {
            ShowOptions();
        }
        public void ShowOptions()
        {
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Square");
            Console.WriteLine("6) Square Root");
            Console.WriteLine("7) Power");
            Console.WriteLine("8) Exit \n");

            InputOption();
        }
      


        public void InputNumber1()
        {
            Console.WriteLine("Input Numeber 1:");

            if (!double.TryParse(Console.ReadLine(), out double number1))
            {
                Console.WriteLine("Invalid input, Try again:");
                InputNumber1();
            }
            Num1 = number1;
        }
        public void InputNumber2()
        {
            Console.WriteLine("Input Number 2");
            if (!double.TryParse(Console.ReadLine(), out double number2))
            {
                Console.WriteLine("Invalid input, Try again:");
                InputNumber2();
            }
            Num2 = number2;
        }

        public void InputOption()
        {
            if (!Int32.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input, Try again:");
                InputOption();
            }
            ChooseOption();
        }

        public double Add()
        {
            Result = Num1 + Num2;
            Console.WriteLine("Result: " + Result);
            return Result;
        }
        public double Subtract()
        {
            Result = Num1 - Num2;
            Console.WriteLine("Result: " +Result);
            return Result;
        }

        public double Multiplicate()
        {
            Result = Num1 * Num2;
            return Result;
        }

        public double Divide()
        {
            
            if (Num2 == 0)
            {
                Console.WriteLine("Cannot Divide by zero");
                InputNumber2();
            }
            
            Result = Convert.ToDouble(Num1) / Num2;
            Console.WriteLine("Result: " + Result);
            return Result;
        }
        public double Square(double number)
        {
            Result = Math.Pow(number, 2);
            Console.WriteLine("Result: " + Result);
            return Result;
        }
        public double SquareRoot(double number)
        {
            Result = Math.Sqrt(number);
            Console.WriteLine("Result: " + Result);
            return Result;
        }
        public double Power(double number1, double number2)
        {
            Result = Math.Pow(number1, number2);
            Console.WriteLine("Result: " + Result);
            return Result;
        }
        public void ChooseOption()
        {
            switch(option)
            {
                case 1:
                    InputNumber1();
                    InputNumber2();
                    Add();
                    ShowOptions();
                    break;
                    
                case 2:
                    InputNumber1();
                    InputNumber2();
                    Subtract();
                    ShowOptions();
                    break;
                case 3:
                    InputNumber1();
                    InputNumber2();
                    Multiplicate();
                    ShowOptions();
                    break;
                case 4:
                    InputNumber1();
                    InputNumber2();
                    Divide();
                    ShowOptions(); 
                    break;
                case 5:
                    InputNumber1();
                    Square(Num1);
                    ShowOptions();
                    break;
                case 6:
                    InputNumber1();
                    SquareRoot(Num1);
                    ShowOptions();
                    break;
                case 7:
                    InputNumber1();
                    InputNumber2();
                    Power(Num1, Num2);
                    ShowOptions();
                    break;
                case 8:
                    break;
                case > 8:
                    Console.WriteLine("Error, try Again:");
                    ShowOptions();
                    break;



            }
        }
    }
}
