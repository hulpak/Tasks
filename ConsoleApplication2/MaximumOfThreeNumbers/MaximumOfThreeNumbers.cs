using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumOfThreeNumbers
{
    class MaximumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split();
            var first = arr.First().ToString();
            int[] a = Array.ConvertAll(arr, int.Parse).ToArray();
            int max = a[0] > a[1] ? (a[0]>a[2]?a[0]:a[2]): ((a[1] > a[2]) ? a[1] : a[2]);
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
