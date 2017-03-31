using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticProgressionNth
{
    class ArithmeticProgressionNth
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split();
            var first = arr.First().ToString();
            int[] a = Array.ConvertAll(arr, int.Parse).ToArray();

            int arithm = ProgressNth(a[0], a[1], a[2]);

            Console.Write(arithm + " ");
            Console.ReadKey();
        }

        static int ProgressNth(int a, int d, int n)
        {
            if (n == 1) return a;
            return a + (n - 1) * d ;
        }
    }
}
