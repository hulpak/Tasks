using System;
using System.Linq;

namespace DistanceBetweenTwoPoints3D
{
    class DistanceBetweenTwoPoints3D
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split();
            var first = arr.First().ToString();
            double[] a = Array.ConvertAll(arr, double.Parse).ToArray();

            Point p1 = new Point(a[0],a[1],a[2]);
            double dist = Math.Round(p1.distance(p1, new Point(a[3], a[4], a[5])));
            Console.Write(String.Format("{0:0.00000000}", dist));
            Console.ReadKey();
        }
    }

    class Point
    {
        double x { set; get; }
        double y { set; get; }
        double z { set; get; }

        public Point(double x, double y, double z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double distance(Point p1, Point p2) {
            return Math.Sqrt(Math.Pow((p2.x-p1.x),2)+ Math.Pow((p2.y - p1.y),2) + Math.Pow(p2.z - p1.z,2));
        }
        
    }
}
