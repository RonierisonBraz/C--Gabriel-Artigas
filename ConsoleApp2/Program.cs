using System;

namespace EntradaNumerica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número inteiro:  ");
            string aStr = Console.ReadLine();
            int a = int.Parse(aStr); // Posso fazer assim 

            Console.Write("Digite o segundo número inteiro:  ");            
            int b = int.Parse(Console.ReadLine());// Ou posso fazer assim 

            Console.WriteLine($"{a} / {b} = {a / b} e a sobra {a % b}"); //divisão e resto


            Console.Write("Digite o valor de double:  ");
            double c = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de decimal:  ");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine($"O numero digitado para double foi ..: {c}");
            Console.WriteLine($"O numero digitado para decimal foi ..: {d}");

        }
    }
}
