using System;

namespace ClassesBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(10, 20);

            Point3D b = new Point3D(50, 30, 25);

            Console.WriteLine($"a : {a.X}, {a.Y}");
            Console.WriteLine($"b : {b.X}, {b.Y}, {b.Z}");
                      
        }
    }

    public class Point
    { 
        public int X { get; }

        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

    }
    public class Point3D : Point
    {

        public int Z { get; }

        public Point3D(int x, int y, int z) : base (x, y)
        {
            
            Z = z;
        }
      
    }
}

