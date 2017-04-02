using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleBetweenTwoVectors3D
{
    class AngleBetweenTwoVectors3D
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split();
            var first = arr.First().ToString();
            double[] a = Array.ConvertAll(arr, double.Parse).ToArray();

            Point p1 = new Point(a[0], a[1], a[2]);
            double dist = p1.angle(p1, new Point(a[3], a[4], a[5]));
            Console.WriteLine(String.Format("{0:0.00000000}", dist));
            Console.ReadKey();
        }
      
        }
    class Point
    {
        double x { set; get; }
        double y { set; get; }
        double z { set; get; }

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double angle(Point p1, Point p2)
        {
            double uv = (p1.x * p2.x) + (p1.y * p2.y) + (p1.z * p2.z);
            double u = Math.Sqrt(Math.Pow(p1.x, 2) + Math.Pow(p1.y, 2) + Math.Pow(p1.z, 2));
            double v = Math.Sqrt(Math.Pow(p2.x, 2) + Math.Pow(p2.y, 2) + Math.Pow(p2.z, 2));
            double ang = Math.Acos(Math.Round((uv / (u * v))));
            return ang;
        }
    }
}

