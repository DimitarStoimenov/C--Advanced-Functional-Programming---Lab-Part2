using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> input = x => x += x * 0.2m;
            decimal[] upperstr = Console.ReadLine().Split(", ").Select(decimal.Parse).Select(input).ToArray();
            foreach (decimal item in upperstr)
            {
                Console.WriteLine($"{item:f2}");
            };


        }
    }
}
