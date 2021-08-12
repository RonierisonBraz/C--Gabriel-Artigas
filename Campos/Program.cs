using System;

namespace Campos
{
    class Program
    {
        static void Main(string[] args)
        {
            var redColor = new Color(255,0,0);
            
            Console.WriteLine(redColor.R);
            Console.WriteLine(redColor.G);
            Console.WriteLine(redColor.B);

            var greenColor = Color.Green;
            Console.WriteLine(greenColor.R);
            Console.WriteLine(greenColor.G);
            Console.WriteLine(greenColor.B);

        }
    }

    public class Color
    {
        public static readonly Color Black = new Color(0, 0, 0); //codigos das cores instancia do objeto, readonly quer dizer que é so para leitura 

        public static readonly Color White = new Color(255, 255, 255);

        public static readonly Color Red = new Color(255, 0, 0);

        public static readonly Color Green = new Color(0, 255, 0);

        public static readonly Color Blue = new Color(0, 0, 255);

        public byte R;

        public byte G;
        
        public byte B;

        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
    }
}
