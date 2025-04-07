using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(3);
            set.Add(4);
            set.Add(4);
            set.Add(2);
            set.Add(3);
            set.Add(3);
            set.Add(4);
            set.Add(2);
            foreach (var A in set)
            {
                Console.WriteLine(A);
            }
        }
    }
}
