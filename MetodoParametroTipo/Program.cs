using System;

namespace MetodoParametroTipo
{
    class Program
    {
        static void Main(string[] args)
        {
            var mClasse = new MinhaClasse();

           string nome = mClasse.MeuMetodo<string>("Ronierisom");
            int idade = mClasse.MeuMetodo<int>(36);
            Console.WriteLine($"{nome} tem {idade}");

            mClasse.MostrarTipo<double>(18.75);

            mClasse.OutroMetod("Ronierison", 10); //se eu não definir o tipo o valor que for recebido como parametro e vai entender.

        }

        class MinhaClasse
        {
            public T MeuMetodo<T>(T valor)
            {
                return valor;
            }

            public void OutroMetod<T1, T2>(T1 valor1, T2 valor2)
            {
                Console.WriteLine(valor1.GetType());
                Console.WriteLine(valor2.GetType());
            }

            public void MostrarTipo<T>(T valor)
            {
                Type tipo = valor.GetType();
                Console.WriteLine($"o tipo .net de {valor} é {tipo}");
            }
        }
    }  
}
 