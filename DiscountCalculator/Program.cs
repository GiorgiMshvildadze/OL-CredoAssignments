namespace DiscountCalculator;

class Program
{
    public static int price = 100;
    public static int age;

    public static void GetAgeInput()
    {
        
        while (true)
        {
            Console.WriteLine("Enter your Age:");
            if (!Int32.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid input.");
                break;
            }
            else
            {
                CalculateDiscount();
            }   
        }
    }
    
    public static void CalculateDiscount()
    {
        switch (age)
        {
            case < 18:
                Console.WriteLine("Your Discounted price is: ");
                Console.WriteLine( price = price * 75 / 100 );
                break;
            case < 65:
                Console.WriteLine("Your Discounted price is: ");
                Console.WriteLine( price);
                break;
            case < 120:
                Console.WriteLine("Your Discounted price is: ");
                Console.WriteLine( price*85/100);
                break;
            default: Console.Write("Enter valid age: \n");
                break;
        }
    }
    static void Main(string[] args)
    {
        GetAgeInput();
        
    }
}