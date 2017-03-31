using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split();
            var first = arr.First().ToString();
            double[] number = Array.ConvertAll(arr, double.Parse).ToArray();

            Triangles t = new Triangles(number[0],number[1],number[2]);
            Console.WriteLine(t.Perimetr()+" "+t.Area()+" "+t.Radius());

            Console.ReadKey();

        }
    }

    class Triangles {
        double x { set; get; }
        double y { set; get; }
        double z { set; get; }
        public Triangles(double x, double y,double z) {
            this.x = x;
            this.z = z;
            this.y = y;
        }

        public double Area() {
            double p = (x + y + z) / 2;
            return Math.Sqrt(p*(p-x)*(p-y)*(p-z));
        }

        public double Perimetr() {
            return x+y+z;
        }

        public double Radius() {
            double r = Math.Sqrt((Area() - x) * (Area() - y) * (Area() - z) / Area());
            return r;
        }
    }
}
