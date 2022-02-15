/* 14 - Faça um algoritmo que recebe uma palavra e retorne se a palavra é palíndromo.
(Palavra que se pode ler, indiferentemente, da esquerda para direita ou vice-versa. Ex: osso,
Ana e etc). */

using System;
using System.Linq;
using static System.Console;

namespace Palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Digite uma palavra: ");
            var palavra = ReadLine().ToUpper();

            var palindromo = new string(palavra.Reverse().ToArray());

            if (palavra == palindromo)
                WriteLine("A palavra digitada é um palíndromo!");
            else
            {
                WriteLine("A palavra não é um palíndromo!");
            }

        }
    }
}
