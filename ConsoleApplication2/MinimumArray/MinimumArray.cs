using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumArray
{
    class MinimumArray
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split();
            int[] number = Array.ConvertAll(arr, int.Parse).TakeWhile(i => i != -1).ToArray();
            int min = number.Min(p=>p);
                Console.Write(min);
            Console.ReadKey();
        }
    }
}
