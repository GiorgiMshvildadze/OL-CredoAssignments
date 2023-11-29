namespace EventDrivenTemperatureMonitor;

class Program
{
    static void Main()
    {
        var temperatureMonitor = new TemperatureMonitor();
        temperatureMonitor.HighTemperature += HighTemperatureMessage;
        temperatureMonitor.LowTemperature += LowTemperatureMessage;
        temperatureMonitor.IncreaseTemperature(34);
        temperatureMonitor.DecreaseTemperature(15);
        temperatureMonitor.IncreaseTemperature(18);

    }
    public static void HighTemperatureMessage()
    {
        Console.WriteLine("Temperature is above limit!");
    }

    public static void LowTemperatureMessage()
    {
        Console.WriteLine("Temperature Is below limit!");
    }
}