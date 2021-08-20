using System;

namespace DelegadosELambda
{
    class Program
    {

        delegate double Function(double a, double b);

        static void Main(string[] args)
        {
            Function operation = Somar;

            Console.WriteLine(operation(10, 10.8));

            operation = (x, y) => x * y; //essa expressão lambda é a mesma coisa que fazer o metodo abaixo. Lambda so metodos anonimos 

            Console.WriteLine(operation(5,3));
        }

        public static double Somar(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
