using System;

namespace ArrayParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            var mClass = new MinhaClasse();
            mClass.Parametros("Gabriel", 36, 1985);

            mClass.ListarNomes("roniérison", "braz");

            
        }

        class MinhaClasse
        {
            public void Parametros(params object[] argumentos)
            {
                foreach (var item in argumentos)
                {
                    Console.WriteLine(item);
                }
            }

            public void ListarNomes(params string[] nomes)
            {
                foreach (var item in nomes)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
