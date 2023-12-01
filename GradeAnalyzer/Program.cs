using System.Security.Cryptography.X509Certificates;

namespace GradeAnalyzer;

class GradeAnalyzer
{
    public static string input = Console.ReadLine();
    public static string[] gradesArray = input.Split(",");
    public static List<int> convertedGradesArray = new List<int>();
    public static double average = 0;

    public static List<int> ConvertGradesToInt()
    {
        foreach(string grade in gradesArray)
        {
            convertedGradesArray.Add(Convert.ToInt32(grade));
        }
        return convertedGradesArray;
    }
    public static double CalculateAverage()
    {
        ConvertGradesToInt();
        foreach(int grade in convertedGradesArray)
        {
            average+= (double)grade/convertedGradesArray.Count;
        }
        Console.WriteLine("Average is: "+average);
        return average;
    }
    public static void DetermineLetterGrade()
    {
        switch (average)
        {
            case <= 60:
                Console.WriteLine("Grade is F");
                break;
            case <= 70:
                Console.WriteLine("Grade is D");
                break;
            case <= 80:
                Console.WriteLine("Grade is C");
                break;
            case <= 90:
                Console.WriteLine("Grade is B");
                break;
            case <= 100:
                Console.WriteLine("Grade is A");
                break;
        }
    }
    static void Main()
    {
        Console.Write("Enter Grades separated by commas: ");
        CalculateAverage();
        DetermineLetterGrade();
                   
    }
}