using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "this is a test. This is only a test.";
            string[] words = Regex.Split(input.ToLower(), @"\W+");
            HashSet<string> uniqueWords = new HashSet<string>(words);
            Console.WriteLine(uniqueWords.Count);
        }
    }
}
