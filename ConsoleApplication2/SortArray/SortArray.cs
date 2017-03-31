using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class SortArray
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split();
            var first = arr.First().ToString();
            int[] number = Array.ConvertAll(arr, int.Parse).Skip(1).OrderBy(i=>i).ToArray();

            foreach (int i in number)
                Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
