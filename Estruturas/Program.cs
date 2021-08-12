using System;

namespace Estruturas
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(15.2, 7.5);

        }

        public struct Point 
        {
            public double X { get; }
            public double Y { get; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
    }
}
