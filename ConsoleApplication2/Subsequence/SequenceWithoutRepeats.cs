using System;
using System.Linq;

namespace Subsequence
{
    class SequenceWithoutRepeats
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] str = line.Split();
            int []array =Array.ConvertAll(str,int.Parse).TakeWhile(i => i != -1).Distinct().Concat(new[] { -1 }).ToArray();
            
            foreach (int i in array)
                Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
