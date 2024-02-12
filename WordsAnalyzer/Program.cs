using System.Diagnostics;

namespace WordsAnalyzer;


class Program
{
    static async Task Main()
    {
        WordsAnalyzer WordsAnalyzer = new WordsAnalyzer();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        await WordsAnalyzer.AnalyzeFile();
        await WordsAnalyzer.FindWordWithMostVowels();
        stopwatch.Stop();
        decimal timeElapsed = stopwatch.ElapsedMilliseconds;
        await Console.Out.WriteLineAsync($"Time elapsed: {timeElapsed}");
    }
}