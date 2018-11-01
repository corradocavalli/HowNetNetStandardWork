using System;

namespace SuperCalculator
{
    public class SmartCalculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int DaysToChristmas()
        {
            var christmas = new DateTime(2018, 12, 25);
            var now = DateTime.Now;
            return (int)(christmas - now).TotalDays;
        }

    }
}
