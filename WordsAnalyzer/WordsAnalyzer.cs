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
        public async Task AnalyzeFile()
        {
            string text = await File.ReadAllTextAsync(filePath);
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

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

            await Console.Out.WriteLineAsync(longestWord);
            await Console.Out.WriteLineAsync(shortestWord);
        }
        

    }
}
