using System;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write(Fact(number));
            Console.ReadKey();
        }
        static int Fact(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Fact(number - 1);
            }
        }
    }
}
