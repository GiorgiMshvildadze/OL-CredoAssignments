using System.Text.RegularExpressions;

namespace FileAnalyzer;

public class Program
{
    public static string filePath = Console.ReadLine();


    public static int CountWords(string text)
    {
        int count = 0;
        string[] wordsArray = text.Split(new char[] { ' ' , '&' },StringSplitOptions.RemoveEmptyEntries); 
        foreach (string word in wordsArray)
        {
            count++;
        }
        return count;
    }

    public static string FindLongestWord(string text)
    {
        string[] wordsArray = text.Split(new char[] { ' ',',','.',':','"','\'',';', '&' }, StringSplitOptions.RemoveEmptyEntries);
        string longestWord = wordsArray[0];
        for(int i = 1; i < wordsArray.Length-1; i++)
        {
            if (longestWord.Length < wordsArray[i].Length)
            {
               longestWord = wordsArray[i];
            }
        }
        return longestWord;
    }
    static void Main()
    {
        Console.WriteLine("Enter Full file path:");
        var fileContent = File.ReadAllText(filePath);
        Console.WriteLine(fileContent);
        Console.WriteLine(CountWords(fileContent));
        Console.WriteLine(FindLongestWord(fileContent));
       

    }
}