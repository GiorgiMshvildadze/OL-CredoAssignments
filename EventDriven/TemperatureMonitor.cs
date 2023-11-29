using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenTemperatureMonitor
{
    public delegate void Delegate();
    public class TemperatureMonitor
    {
        public event Delegate HighTemperature;
        public event Delegate LowTemperature;



        private const int LowTemp = -10;
        private const int HighTemp = 35;

        private int _currentTemperature = 0;


        public void IncreaseTemperature(int temp)
        {
            _currentTemperature += temp;
            if (_currentTemperature > HighTemp)
            {
                HighTemperature();
            }
            else
            {
                Console.WriteLine($"Temperature now: {_currentTemperature}");
            }

        }
        public void DecreaseTemperature(int temp)
        {
            _currentTemperature -= temp;
            if (_currentTemperature < LowTemp)
            {
                LowTemperature();
            }
            else
            {
                Console.WriteLine($"Temperature now: {_currentTemperature}");
            }

        }

    }
}