using System;
using System.Configuration;

namespace Problem2
{
    /// <summary>
    /// This Console application will shuffle avoiding duplicates
    /// an ordered list, creating a shuffled array of int
    /// 
    /// Note: I purposely left the performance counter in order to show elapsed time
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 0;
            if (int.TryParse(ConfigurationManager.AppSettings["Limit"], out limit))
            {
                var sw = System.Diagnostics.Stopwatch.StartNew();
                ShuffleArray shuffle = new ShuffleArray(limit);
                int[] shuffledArray = shuffle.DoShuffle();
                Console.WriteLine("Created a shuffled array of " + shuffledArray.Length + " element");
                sw.Stop();
                Console.WriteLine("Elapsed Time (milliseconds) " + sw.Elapsed.Milliseconds);
                Console.Read();
            }
            else
            {
                Console.WriteLine("Invalid Limit set in configuration file");
                Console.Read();
            }           
        }
    }
}
