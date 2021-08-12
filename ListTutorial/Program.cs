using System;
using System.Collections.Generic;

namespace ListTutorial
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
            

            foreach(var nome in nomes)
            {
                
                Console.WriteLine($"Olá:  {nome}");
                
            }
           
        }
    }
}
