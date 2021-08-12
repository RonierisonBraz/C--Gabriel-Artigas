using System;

namespace OrdemDePrecendencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            int c = 2;
            
            int d = a + b * c; //mesmas regras de precedencia 
            Console.WriteLine(d);
            
            
            d = (a + b) * c; 
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;

            Console.WriteLine(h);
       
        }
    }
}
