using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Maria");
            set.Add("Ivan");
            set.Add("Georgi");
            if(set.Contains("Georgi"))
            {
                Console.WriteLine("Imeto sustestvuva");
            }
            else
            {
                Console.WriteLine("Nqma go");
            }
        }
    }
}
