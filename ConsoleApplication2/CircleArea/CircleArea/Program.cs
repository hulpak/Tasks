using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
             double number = Double.Parse(Console.ReadLine());

            double area = Math.Round((Math.Pow(number, 2)) / (4 * Math.PI),9);
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
