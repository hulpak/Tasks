using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProgressionSum
{
    class GeometricProgressionSum
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split();
            var first = arr.First().ToString();
            double[] a = Array.ConvertAll(arr, double.Parse).ToArray();

            double arithm = GeometricProgress(a[0], a[1], a[2]);

            Console.Write(arithm + " ");
            Console.ReadKey();
        }

        static double GeometricProgress(double b1, double q, double n)
        {
            if (n == 1) return b1;
            return  q * GeometricProgress( b1, q, n - 1);
        }
    }
}
