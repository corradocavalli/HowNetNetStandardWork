using System;
using SuperCalculator;

namespace SmartConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartCalculator calc=new SmartCalculator();
            int result = calc.Sum(3, 2);
            Console.WriteLine($"Calculation result is {result}");
            Console.ReadLine();
        }
    }
}
