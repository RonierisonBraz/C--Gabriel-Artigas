using System;

namespace ClasssesEObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Point p1 = new Point();pode ser fazer assim porem por convenção se faz do jeito do exemplo de baixo
            var p1 = new Point(25, 50);

            p1.CordenadaX = 59;
            p1.CordenadaY = 70;

            var p2 = new Point(10, 20);

            Console.WriteLine("Cordenada X");
            Console.WriteLine($"Cordenada X  {p1.CordenadaX}");
            Console.WriteLine($"Cordenada Y  {p1.CordenadaY}");

            Console.WriteLine("Cordenada Y");
            Console.WriteLine($"Cordenada X  {p2.CordenadaX}");
            Console.WriteLine($"Cordenada Y  {p2.CordenadaY}");
        }
    }

    public class Point
    {
        public int CordenadaX { get; set; }

        public int CordenadaY { get; set; }

        public Point(int cordenadaX, int cordenadaY) => (CordenadaX, CordenadaY) = (cordenadaX, cordenadaY);
      
    }
}
