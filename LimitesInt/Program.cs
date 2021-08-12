using System;

namespace LimitesInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 4;
            int c = 3;

            int d = (a + b) / c;
            int e = (a + b) % c;

            Console.WriteLine($"Quociente...........: {d}");
            Console.WriteLine($"Resto da divisão....: {e}");

            int min = int.MinValue; //valor minimo 
            int max = int.MaxValue; //valor maximo

            Console.WriteLine($"O intevalo de inteiros é {min} até {max}");

            int what = max + 3;

            Console.WriteLine($"um exemplo de estouro {what}");//O valor da resposta é mais proximo do limite min



        }
    }
}
