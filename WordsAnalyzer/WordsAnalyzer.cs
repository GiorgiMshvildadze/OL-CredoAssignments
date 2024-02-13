using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WordsAnalyzer
{
    public class WordsAnalyzer
    {
        string filePath = "C:\\Users\\giorgimshvildadze\\Test\\Files\\words_alpha.txt";
        public string longestWord = null;
        public string shortestWord = null;
        object longestLock = new object();
        object shortestLock = new object();
        char[] vowels = { 'a','e','i','o','u','y'};
        string text = null;
        string[] words = null;
        object vowelsLock = new object();
        string wordWithMostVowels = null;
        int mostVowelWordVowelCount = 0;
        public async Task AnalyzeFile()
        {
            text = await File.ReadAllTextAsync(filePath);
            words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            ConcurrentDictionary<string, int> wordCounts = new ConcurrentDictionary<string, int>();
            
            
            var tasks = words.Select(async word =>
            {
                await Task.Delay(0);

                lock (longestLock)
                {
                    if (longestWord == null || word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }

                lock (shortestLock)
                {
                    if (shortestWord == null || word.Length < shortestWord.Length)
                    {
                        shortestWord = word;
                    }
                }
            });

            await Task.WhenAll(tasks);
            foreach (var pair in wordCounts)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            Console.WriteLine($"Longest word: {longestWord}");
            Console.WriteLine($"Shortest word: {shortestWord}");
        }
        public async Task FindWordWithMostVowels()
        {
            text = await File.ReadAllTextAsync(filePath);
            words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            
            Parallel.ForEach(words, word =>
            {
                int count = 0;

                for (int i = 0;i<= word.Length; i++)
                {
                    if (word.Contains('a') ||
                   word.Contains('e') ||
                   word.Contains("i") ||
                   word.Contains("o") ||
                   word.Contains("u") ||
                   word.Contains("y"))
                    {
                        count++;
                    }

                }
                if (count> mostVowelWordVowelCount)
                {
                    wordWithMostVowels = word;
                    mostVowelWordVowelCount = count;
                }
               
               
            });
            Console.WriteLine(wordWithMostVowels);
        }

    }


}

