using System;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            (double Sum, int Count) t1 = (4.5, 3);
            Console.WriteLine($"a Soma de {t1.Count} elementos é {t1.Sum}.");

            (int Cod, string Produto, double Valor) p1 = (100, "mouse", 45.9);
            Console.WriteLine($"O codigo do produto é {p1.Cod}, nome do produto 
            
            {p1.Produto} e seu valor é:       {p1.Valor}.");
            
        }
    }
}
