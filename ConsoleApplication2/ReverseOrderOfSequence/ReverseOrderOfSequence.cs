﻿using System;
using System.Linq;

namespace ReverseOrderOfSequence
{
    class ReverseOrderOfSequence
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split();
            int[] number = Array.ConvertAll(arr, int.Parse).TakeWhile(i => i != -1).Reverse().Concat(new[] { -1 }).ToArray();
            foreach (int i in number)
                Console.Write(i + " ");
              Console.ReadKey();
        }
    }
}
