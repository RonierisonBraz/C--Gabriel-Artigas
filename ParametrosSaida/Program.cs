using System;

namespace ParametrosSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            var mClass = new MinhaClasse();

            double valor1 = 10;
            double valor2 = 5;
            double resultado;

            mClass.Calcular(valor1, valor2,out resultado);

            Console.WriteLine($"{valor1} + {valor2} = {resultado}");
           
        }

        class MinhaClasse 
        {
            public void Calcular(double n1, double n2, out double res)
            {
                res = n1 + n2;
            }
        }
    }
}
