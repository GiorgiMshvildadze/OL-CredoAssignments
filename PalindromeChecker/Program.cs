using System.Text.RegularExpressions;

class Program
{
    public static string reverse = String.Empty;
    public static string input;
    public static string pattern = "[,. ]"; 

    public static string Reverse(string text)
    {
        char[] cArray = text.ToCharArray();
        for (int i = cArray.Length - 1; i >= 0; i--)
        {
            reverse += cArray[i];
        }
        return reverse.ToLower();
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a text: ");
        input = Console.ReadLine().ToLower(); 

        string cleanedInput = Regex.Replace(input, pattern, "");

        Reverse(cleanedInput);

        if (cleanedInput == reverse)
        {
            Console.WriteLine("Text is a palindrome");
        }
        else
        {
            Console.WriteLine("Text is not a palindrome");
        }
    }
}






