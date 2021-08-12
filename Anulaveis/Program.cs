using System;

#nullable enable

namespace Anulaveis
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            int? optionalInt = null;
            Console.WriteLine(optionalInt);

            if(optionalInt < 1)
            {
                
            }

             optionalInt = 5;
            Console.WriteLine(optionalInt);

            string? optionalText = default;
            Console.WriteLine(optionalText);

            optionalText = "Hello World";
            Console.WriteLine(optionalText);
        }

    
    }
}
