using System;

namespace TrabalharComInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 6;

            // adição 

            int c = a + b;

            Console.WriteLine($"{a} + {b} = {c}");
            Console.WriteLine($"{a} + {b} = {a + b}"); //outra maneira de fazer, serve para as outras operações 

            //subtração 
            c = a - b;

            Console.WriteLine($"{a} - {b} = {c}");

            //multiplicação
            c = a * b;

            Console.WriteLine($"{a} * {b} = {c}");

            //divisão 
            c = a / b;

            Console.WriteLine($"{a} / {b} = {c}");

            //resto
            c = a % b;

            Console.WriteLine($"{a} % {b} = {c}");





        }
    }
}
