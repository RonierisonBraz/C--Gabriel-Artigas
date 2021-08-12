using System;
using System.Collections.Generic;

namespace ListasDeOutrosTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            while(fibonacciNumbers.Count <= 20) 
            { 

            var anterior = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var anterior2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            fibonacciNumbers.Add(anterior + anterior2);
            
            }

            foreach (var item in fibonacciNumbers)
            {

                Console.Write($"/ {item}");
            }
        }
    }
}
