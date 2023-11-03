namespace DayPlanner;

class Program
{
    public enum Days
    {
        Monday, 
        Tuesday,
        Wednesday,
        Thursday,
        Friday, 
        Saturday, 
        Sunday

    }

   
    static void Main(string[] args)
    {
        string weekdayActivity = "Go To Work";
        string weekendActivity = "Go out to see friends";
        
        Console.WriteLine("Enter a day of the week: ");
        var weekdayString = Console.ReadLine();
        Enum.TryParse(weekdayString, out Days day);

        switch(day)
        {
            case Days.Monday:
            case Days.Tuesday:
            case Days.Wednesday:
            case Days.Thursday:
            case Days.Friday:
                Console.WriteLine(weekdayActivity);
                break;
            case Days.Saturday:
            case Days.Sunday:
                Console.WriteLine(weekendActivity);
                break;

        }

    }
}