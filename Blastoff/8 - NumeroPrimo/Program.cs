/* 8 - Faça um algoritmo que receba um número e retorne se o número é primo ou não. */

using System;
using static System.Console;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Digite um número, por favor: ");
            var numero = int.Parse(ReadLine());

            VerificarNumero(numero);
        }

        public static int VerificarNumero(int numero)
        {
            for(int i = 2; i < numero; i++)
            {
                if(numero % i == 0)
                {
                    WriteLine($"{numero} não é um número primo.");
                    return numero;
                }
            }
            
            WriteLine($"{numero} é um número primo.");
            return numero;
        }
    }
}
