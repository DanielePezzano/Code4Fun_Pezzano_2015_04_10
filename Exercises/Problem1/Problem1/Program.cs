using System;
using System.Configuration;

namespace Problem1
{
    /// <summary>
    /// In this console application I want to find the sum of all multiple of 3 or 5
    /// below 1000.
    /// Note: I purposely left the performance counter
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 0;

            if (int.TryParse(ConfigurationManager.AppSettings["Limit"], out limit))
            {
                var sw = System.Diagnostics.Stopwatch.StartNew();
                SeriesCalculation calc = new SeriesCalculation();
                Int64 sum = calc.CalculateSum(3, limit) + calc.CalculateSum(5, limit);
                Console.WriteLine("Total = " + sum);
                sw.Stop();
                Console.WriteLine("Elapsed Time (milliseconds): " + sw.Elapsed.Milliseconds);
                Console.Read();
            }
        }
    }
}
