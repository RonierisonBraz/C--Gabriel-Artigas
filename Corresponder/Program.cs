using System;

namespace Corresponder
{
    class Program
    {
        public enum Comando
        {
            SystemTest, Start, Stop, Reset
        }

        static void Main(string[] args)
        { 
            int caseSwitch = 3;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");

                    break;
                case 2:
                    Console.WriteLine("Case 2");

                    break;
                default:
                    Console.WriteLine("No Case");
                    break;
            }

            string dia = "Quarta";

            switch (dia)
            {
                case "Segunda":
                    Console.WriteLine("o Primeiro dia de trabalho da semana ");
                    break;
                case "Sabado":
                case "Domingo":
                    Console.WriteLine($"Hoje é {dia}. Dia de folga");
                    break;
                default:
                    Console.WriteLine($"Hoje é ({dia})");
                    break;
            }

            Comando? c = Comando.SystemTest;

            string op = c switch
            {
                Comando.SystemTest => "Realizando testes no sistema...",
                Comando.Start => "Iniciando o sistema...",
                Comando.Stop => "Parando o sistema...",
                Comando.Reset => "Reiniciando o sistema...",
                _ => "Comando inválido "
            };
            Console.WriteLine(op);
        }
    }
}
