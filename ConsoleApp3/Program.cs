using System;

namespace Verificar
{
    class Program  
    {

       
        static void Main(string[] args)
        {
            //Operadores boolianos
            //== != > < >= <=

            int a = 5;
            int b = 6;

            if((a + b) > 10)
            {
                Console.WriteLine("Dentro do if");
            }
            string nome = "Roni";
            if((a * 2) != (b + 4))
            {
                Console.WriteLine("A resposta é verdadeira");
                Console.WriteLine("o resultado das expressões são iguais");

                if (nome.StartsWith("A"))
                {
                    Console.WriteLine("e tambem o nome começa com r");
                }
            }



        }
    }
}
