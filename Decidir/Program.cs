using System;

namespace Decidir
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 3;

            if ((a + b) < 10)
            {
                Console.WriteLine($"A resposta é maior que 10");
            }
            else
            {   
                Console.WriteLine($"A resposta não é maior que 10");
            }

            //Operadores lógicos boolianos
            //&& ||

            int c = 4;

            if ((a + b + c > 10) && (a == b)) 
            {
                Console.WriteLine("A resposta é maior do que 10");
                Console.WriteLine("e o primeiro número é igual ao segundo");
            }
            else
            {
                Console.WriteLine("A resposta não é maior do que 10");
                Console.WriteLine("ou primeiro número não é igual ao segundo");
            }

            Console.WriteLine();

            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("A resposta é maior do que 10");
                Console.WriteLine("ou primeiro número é igual ao segundo");
            }
            else
            {
                Console.WriteLine("A resposta não é maior do que 10");
                Console.WriteLine("e o primeiro número não é igual ao segundo");
            }


        }
    }
}
