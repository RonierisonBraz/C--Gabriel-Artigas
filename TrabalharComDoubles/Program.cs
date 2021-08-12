using System;

namespace TrabalharComDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine($"({a} + {b}) / {c} = {d}");


            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            Console.WriteLine($"({e} + {f}) / {g} = {h}");

            double min = double.MinValue;
            double max = double.MaxValue;

            Console.WriteLine($"O intervalo do double é de {min} até {max}");

            double terceiro = 1.0 / 3.0; //tem que colocar .0 para que a variavel identifique que é double
            Console.WriteLine(terceiro);

        }
    }
}
