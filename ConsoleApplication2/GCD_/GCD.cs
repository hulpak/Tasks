using System;
using System.Linq;
namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        
        {
                string line = Console.ReadLine();
                string[] arr = line.Split();
                var first = arr.First().ToString();
                int[] number = Array.ConvertAll(arr, int.Parse).ToArray();
                Console.Write(GCD(number[0], number[1]));
                Console.ReadKey();
            }
            static int GCD(int a, int b)
            {
            if (a == 0 || b == 0) return a + b;
            return GCD(b, a % b);
        }        
    }
}
