using System;

namespace DecidirERepetir
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter =  0;

            while (counter < 10)// executa ate que a condição seja false 
            {
                Console.WriteLine($"While: {counter}");

                counter++;// é a mesma coisa que {counter = counter +1}  

            }

            Console.WriteLine();

           // counter = 20;

            do // execulta pelo menos uma vez 
            {

                Console.WriteLine($"Do while: {counter}");

                counter++;// é a mesma coisa que {counter = counter +1} 

            } while (counter < 10); // executa ate que a condição seja fals

        }
    }
}
