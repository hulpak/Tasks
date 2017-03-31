using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectedMembersOfSequence
{
    class SelectedMembersOfSequence
    {
        static void Main(string[] args)
        {
           string line = Console.ReadLine();
           string[] arr = line.Split();
           int[] number = Array.ConvertAll(arr, int.Parse).TakeWhile(i => i != -1).ToArray();
          var res = number.Where(f => (f % 2) == 1)
                  .ToList();
            
            foreach (object i in res)
                Console.Write(i + " ");

            Console.ReadKey();
        }
    }
}
