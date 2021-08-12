using System;
using System.Collections.Generic;
 
namespace MaisSobreList
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = new List<string>
            {
                "Gabriel" , "Danny", "Arthur", "Maria", "Beatriz"
            };


            var index = nomes.IndexOf("Arthur");

            if (index == -1)
            {
                Console.WriteLine($"Quando um item não for encontrado, Index retorna {index}");
            }
            else
            {
                Console.WriteLine($"O nome {nomes[index]} esta no indice {index}");
            }

           index = nomes.IndexOf("Flavio");// pesquisa dentro da lista a string que 

            if (index == -1)
            {
                Console.WriteLine($"Quando um item não for encontrado, Index retorna {index}");
            }
            else
            {
                Console.WriteLine($"O nome {nomes[index]} esta no indice {index}");
            }

            nomes.Sort();// organiza a ordem numerica ou alfabetica

            foreach (var nome in nomes)
            {
                Console.WriteLine($"Ola! {nome}");
            }
        }
    }
}
