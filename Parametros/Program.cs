using System;

namespace Parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            var mClass = new MinhaClass();

            int n1 = 10;

            mClass.ParametrosValor(n1);
            Console.WriteLine($"Variavel original {n1}");

            mClass.ParametrosReferencia(ref n1);
            Console.WriteLine($"Variavel original {n1}");
        }

        class MinhaClass
        {
            public void ParametrosValor(int num)
            {
                num *= 2;
                Console.WriteLine($"O dobro é {num}");
            }

            public void ParametrosReferencia(ref int num)
            {
                num *= 2;
                Console.WriteLine($"O dobro é {num}");
            }
        }
    }
}
