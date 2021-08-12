using System;

namespace MetodosRetorno
{
    class Program
    {
        static void Main(string[] args)
        {
            var mClasse = new MinhaClasse();

            mClasse.MetodoSemRetorno();

            int valor = 10;
            int dobroValor = mClasse.DobrarValor(valor);
            Console.WriteLine($"O dobro do valor {valor} é {dobroValor}");

            double valor2 = 100;
            double res = mClasse.Dividir(valor2, 2);
            Console.WriteLine($"O resultado da divisão é {res}");

            int qtd = mClasse.QuantidadeCaracteres("Ronierison");
            Console.WriteLine($"A quantidade de caracteres do nome é {qtd}");

        }

        class MinhaClasse
        {
            public void MetodoSemRetorno()
            {
                Console.WriteLine("Este metodo não retorna valor");
            }

            public int DobrarValor(int n1)
            {
                int res = n1 * 2;
                return res;
            }

            //os argumentos de entrada não precisam ser do mesmo tipo
            public double Dividir(double n1, double n2) => n1 / n2;

            public int QuantidadeCaracteres(string nome) => nome.Length;
           
        }
    }
}
