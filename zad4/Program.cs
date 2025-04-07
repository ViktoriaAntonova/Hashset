using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4 };
            List<int> list2 = new List<int> { 5, 6, 7, 3 };
            HashSet<int> set1 = new HashSet<int>(list1);
            HashSet<int> set2 = new HashSet<int>(list2);
            foreach (var item in set1)
            {
                if (set2.Contains(item))
                {
                    Console.WriteLine($"Obsht element: {item}");
                    return; 
                }
            }
            Console.WriteLine("Nqma obsht");
        }
    }
}
