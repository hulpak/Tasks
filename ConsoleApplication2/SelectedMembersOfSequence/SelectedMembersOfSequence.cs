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
            int[] number = Array.ConvertAll(arr, int.Parse).TakeWhile(j => j != -1).ToArray();
            SelectedMember(number);


            Console.ReadKey();
        }
        public static void SelectedMember(int[] number)
        {
            int k = 0;
            int i = 1;
            Boolean f = true;
            while (f)
            {
                if ((2 * k + i) < number.Length)
                {
                    Console.Write(number[2 * k + i] + " ");
                    i++;
                    k++;
                }
                else
                {
                    f = false;
                    Console.Write("-1");
                }
            }
        }
    }
}
