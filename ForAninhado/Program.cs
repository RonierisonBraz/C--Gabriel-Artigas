using System;

namespace ForAninhado
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //Um loop for pede gerar as linhas:
             for (int row = 1; row < 11; row++)
             {
                 Console.WriteLine($"A linha é {row}");
             }


             //Outro loop pode gerar as colunas:
             for (Char column = 'a'; column < 'k'; column++)
             {
                 Console.WriteLine($"A coluna é {column}");
             }
         */


            /*  Você pode aninhar u loop dentro do outro para forma pares
             *  for (int row = 1; row < 11; row++)
              {
                  for (Char column = 'a'; column < 'k'; column++)
                  {
                      Console.WriteLine($"A Célula é ({row}, {column})");
                  }
              }*/


            for (int row = 1; row < 11; row++)
            {
                for (Char column = 'a'; column < 'k'; column++)
                {
                    Console.Write($"({row}, {column})");
                }
                Console.WriteLine();
            }
        }
    }
}
