using System;

namespace PesquisarCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            string songLyrics = "Você disse adeus, e eu disse olá";
            Console.WriteLine(songLyrics.Contains("adeus")); // pesquisar uma palavra dentro da string porem o retorno dele é tipo boolean
            Console.WriteLine(songLyrics.Contains("saudações"));


            Console.WriteLine(songLyrics.StartsWith("Você"));// pesquisa se a cadeia de caracteres inicia com a palavra que foi passada 
            
            Console.WriteLine(songLyrics.EndsWith("Olá"));// pesquisa se a cadeia de caracteres finaliza com a palavra que foi passada 

            if(songLyrics.Contains("saudações") || )
            {

            }



        }
    }
}
