// 5 - Faça um algoritmo para apresentar se dois números são múltiplos.

using static System.Console;
using System;

namespace NumerosMultiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Digite o primeiro número: ");
            var n1 = int.Parse(ReadLine());

            WriteLine("Digite o segundo número: ");
            var n2 = int.Parse(ReadLine());

            if(n1 % n2 == 0)
                WriteLine($"{n1} e {n2} são múltiplos.");
            else
                WriteLine("Os números não são múltiplos.");
        }
    }
}
