using System;

namespace WeekdayOrWeekend;

class program
{
    static string GetInputDay()
    {

        Console.WriteLine("Enter a day:");
        return Console.ReadLine();
    }

    static void CheckWeekday(string day)
    {
        switch (day)
        {
            case "monday":
            case "tuesday":
            case "wednesday":
            case "thrusday":
            case "friday":
                Console.WriteLine("It is weekday");
                break;
            case "saturday":
            case "sunday":
                Console.WriteLine("it is weekend");
                break;


            default: Console.WriteLine("Enter valid weekday");
                break;
             
        }

        
    }
    
    static  void CheckMonth()
    {        
        DateTime now = DateTime.Now;
        int month = now.Month;
        switch (month)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("its Q1");
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("its Q2");
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine("its Q3");
                break;
            default: Console.WriteLine("its Q4");
                break;
        }
        
    }

    static void Main(String[] args)
    {
        var day = GetInputDay();
        CheckWeekday(day);
        CheckMonth();

    }
}