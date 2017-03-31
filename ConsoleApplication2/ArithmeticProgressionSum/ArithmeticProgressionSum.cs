using System;
using System.Linq;

namespace ArithmeticProgressionSum
{
    class ArithmeticProgressionSum
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split();
            var first = arr.First().ToString();
            int[] a = Array.ConvertAll(arr, int.Parse).ToArray();

            int arithm = ArithmeticProgress(a[0],a[1],a[2]);

            Console.Write(arithm + " ");
            Console.ReadKey();
        }

        static int ArithmeticProgress(int a, int d, int n)
        {
           if (n == 1) return a;
            return a + (n - 1) * d + ArithmeticProgress(n - 1, a, d);
        }
    }
}
