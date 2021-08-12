using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            var mClass = new MinhaClass();
            mClass.MeuMetodo();
            mClass.MeuOutroMetodo();
            string retorno = mClass.ToString();
            Console.WriteLine(retorno);
        }

        class MinhaClass
        {
            public void MeuMetodo()
            {
                Console.WriteLine("Executando um instrução");
            }

            public void MeuOutroMetodo()
            {
                Console.WriteLine("Executando MeuOutroMetodo");
                Console.WriteLine("Que tem mais de um instrunção");

            }

            public override string ToString() // sobre inscrita do metodo toString
            {
                return " Testando objeto";
            }
        }
    }
}
