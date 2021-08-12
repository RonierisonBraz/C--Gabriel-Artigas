using System;

namespace Enumerado
{
    public enum Semaforo
    {
        Verde,
        Amarelo, 
        Vermelho
    }

    [Flags] //serve para mostrar o nome do enum em vez de o valor somado como na linha 49.
    public enum Seasons
    {
        Nome = 0,

        Summer = 1, 

        Autumn = 2, 

        Winter = 4,

        Spring = 8,

        All = Summer | Autumn | Winter | Spring //a soma de todos os enuns


    }
    class Program
    {
        static void Main(string[] args)
        {
            var estado = Semaforo.Vermelho;

            if (estado == Semaforo.Verde)
            {
                Console.WriteLine("pode passar");
            }
            else if (estado == Semaforo.Amarelo)
            {
                Console.WriteLine("Vai que dar para passar");
            }
            else
            {
                Console.WriteLine("Para desgraça");
            }

            var spring = Seasons.Spring;
            var startingOnEquinox = Seasons.Spring | Seasons.Autumn;
            var theYear = (int)Seasons.All;//Cast estou pegando o valor do enum e carregando na variavel.

            Console.WriteLine(spring);
            Console.WriteLine(startingOnEquinox);
            Console.WriteLine(theYear);
        }
    }
}
