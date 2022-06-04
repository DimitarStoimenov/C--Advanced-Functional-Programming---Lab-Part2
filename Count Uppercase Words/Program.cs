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
            Func<string, bool> word = x => x.Length > 0 && char.IsUpper(x[0]);

            string[] input = Console.ReadLine().Split().Where(word).ToArray();
            Console.WriteLine(string.Join("\r\n", input));
        }
    }
}
