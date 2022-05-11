using FizzBuzzLib;
using System;
using System.IO;

namespace FizzBuzzConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();

            foreach (var item in sol.PrintFizzBuzz(100))
            {
                if (item != null)
                {
                    var sr = new StreamReader(item);
                    PrintResults(sr);
                }
            }
        }

        public static void PrintResults(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
