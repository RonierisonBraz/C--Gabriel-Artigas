using System;

namespace TiposEVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Integral assinada: sbyte,short,int long
            //sbyte : 8 bits

            sbyte varSByte = -8;
            Console.WriteLine(varSByte);

            //short  : 16 bits
            short varShort = -16;
            Console.WriteLine(varShort);

            //int : 32 bits
            int varInt = -32;
            Console.WriteLine(varInt);

            //long : 64 bits
            long varLong = -64L;
            Console.WriteLine(varLong);


            //Integral não assinada: byte, ushort, uint, ulong
            //byte : 8 bitds
            byte varByte = 8;
            Console.WriteLine(varByte);

            //ushort : 16 bits
            ushort varUShort = 16;
            Console.WriteLine(varUShort);

            //unit
            uint varUInt = 32;
            Console.WriteLine(varUInt);

            //ulong
            ulong varULong = 64UL;
            Console.WriteLine(varULong);

            //ponto flutuante de binário do IEEE: float, double
            //Sufixo f ou F Obrigatório
            float varFloat = 32.12345f;
            Console.WriteLine(varFloat);

            //Sufxo d ou D não obrigatório 
            double varDouble = 64.1234567890d;
            Console.WriteLine(varDouble);

            // Ponto flutuante decimal de alta precisão: decimal 
            //Sufxo m ou M não obrigatório
            decimal varDecimal = 128.12345678901234567890m;
            Console.WriteLine(varDecimal);

            //Boliano : bool, que representa valores Boolianos - valores que são true ou false.
            bool booliano = false;
            Console.WriteLine(booliano);

            //Caracteres Unicode: char, que representa uma unidade de código UTF-16
            char caractere = 'C';//char : 'C', '7', '@',
            Console.WriteLine(caractere);

            int i = 123;
            object o = i; //Boxing 
            int j = (int)o;//Unboxingº

        }
    }
}
