using System;

namespace ParametrosDeTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Pair<int, string>(1, "Roniérison");
            int i = p1.First;
            string s = p1.Second;

            var p2 = new Pair<string, double>("teclado", 45.75);
            string produto = p2.First;
            double valor = p2.Second;

            Console.WriteLine($"Produto: {produto} - Valor: {valor}");

           /* Console.WriteLine("Digite um valor inteiro");
            string a = Console.ReadLine();
            int valor = int.Parse()


            Console.Write("Digite o primeiro número inteiro:  ");
            string aStr = Console.ReadLine();
            int a = int.Parse(aStr)*/

           /* Console.WriteLine($"Esses são os parametros de P1 {p1.First}, {p1.Second}");*/
        }
    }

    public class Pair<TFirst, TSecond> //Class com parâmentro de tipo
    {
        //public int First { get; }O usuario pode definir que tipo a variavel tera EX: public TFirst

        public TFirst First { get; }

        public TSecond Second { get; }

        public Pair(TFirst first, TSecond second) => (First, Second) = (first, second);


      /*Esse construtor é a mesma coisa que o de cima 
       * public Pair(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }*/

        


    }
}
