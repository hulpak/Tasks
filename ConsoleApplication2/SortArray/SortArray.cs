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
            int first = int.Parse(arr.First().ToString());
            int[] number = Array.ConvertAll(arr, int.Parse).Skip(1).Take(first).OrderBy(i=>i).ToArray();

            Console.Write(first + " ");
            foreach (int i in number)
                Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
