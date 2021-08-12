using System;

namespace TrabalharComDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;

            Console.WriteLine($"O intervalo do tipo decimal é de {min} até {max}");

            double a = 1.0;
            double b = 3.0;
            double c = (a / b);
            decimal d;
            
            d = (decimal)c;//Basico avançado.

            Console.WriteLine($"O Numero em decimal da divisão de {a} por {b} = {c}");

            decimal e = 1.0m;
            decimal f = 3.0m;// para trabalhar com recusos financeiros é melhor trabalhar com Decimal.


            Console.WriteLine($"O Numero em decimal da divisão de {e} por {f} = {(e/f)}");

        }
    }
}
