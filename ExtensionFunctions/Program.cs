

using ExtensionFunctions;

class Program
{
   
    static void Main()
    {
        Console.WriteLine(0.5.ToPercent());
        Console.WriteLine(34.2.RoundDown());
        double ragac = 234.1;
        Console.WriteLine(ragac.ToDecimal().GetType());

    }
}