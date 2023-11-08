using System.Text.RegularExpressions;

namespace TextAnalyzer;

class Program
{
    public static string input = Console.ReadLine().ToLower();
    public static string pattern = "[^a-zA-Z0-9]+";
    static public string[] array = Regex.Split(input, pattern);
    public static Dictionary<string,int> wordsDictionary = new Dictionary<string,int>();

    public static int CountWords()
    {
        int count = 0;
        foreach (string word in array)
        {
            count++;
        }
        return count;
    }

    public static int FindMostCommonWord()
    {
        foreach(string word in array)
        {
            wordsDictionary[word]++;
        }

        return wordsDictionary.Count;
    }
    static void Main(string[] args)
    {
        
     Console.WriteLine(CountWords());
    }
}