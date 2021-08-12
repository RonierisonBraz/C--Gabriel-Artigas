using System;
using System.Collections.Generic;

namespace ModificarLista
{
    class Program
    {
        static void Main(string[] args)
        {
            var nomes = new List<string>
            {
                "Ronierison",
                "Luísa",
                "Laura"
            };

            foreach (var nome in nomes)
                Console.WriteLine($"Olá:  {nome}");

                Console.WriteLine();
                nomes.Add("Maria");
                nomes.Add("Beatriz");
                nomes.Remove("Ronierison");


                foreach (var nome in nomes)
                
                Console.WriteLine($"Meu nome é:  {nome}");
                Console.WriteLine($"Meu nome é:  {nomes[0]}");
                Console.WriteLine($"Eu adicionei {nomes[2]} e {nomes[3]} na lista");

                Console.WriteLine($"A lista tem {nomes.Count} nela");//count exibe a quantidade de itens na lista

            
        }
    }
}
