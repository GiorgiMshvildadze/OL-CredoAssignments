namespace InvestmentForecaster;

class InvestmentForecaster
{
    public static decimal FV;  //Future Value
    public static double P; //Principal Ammount
    public static double r;  //Annual interest rate
    public static int t;  //Time in years
    public static double n = 1;  //Number of times interest is compounded in year

    public static void InputPrincipalAmount()
    {
        Console.Write("Enter the initial principal amount:");
        if (!double.TryParse(Console.ReadLine(), out P))
        {
            Console.WriteLine("Invalid Input");
            InputPrincipalAmount();
        }
        InputAnnualInterestRate();
    }

    public static void InputAnnualInterestRate()
    {
        Console.Write("Enter the annual interest rate:");
        if (!double.TryParse(Console.ReadLine(), out r))
        {
            Console.WriteLine("Invalid Input");
            InputAnnualInterestRate();
        }
        InputNumberOfYears();
    }

    public static void InputNumberOfYears()
    {
        Console.Write("Enter number of years:");
        if (!Int32.TryParse(Console.ReadLine(), out t))
        {
            Console.WriteLine("Invalid Input");
            InputNumberOfYears();
        }
        Console.WriteLine("Future Value is: "+ CalculateFutureValue(t, P, r));
    }

    public static decimal CalculateFutureValue(double time, double initialAmmount, double interest)
    {
        FV = (decimal)(initialAmmount * Math.Pow((1 + (interest / 100 / n)), n * time));

        return FV;
    }
    static void Main(string[] args)
    {
        InputPrincipalAmount();


    }
}