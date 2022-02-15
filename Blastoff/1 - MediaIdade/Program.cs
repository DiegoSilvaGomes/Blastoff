// 1- Dada as idades I, J, K, X, Y. Faça um algoritmo para calcular a média das idades.
using static System.Console;
using System;

namespace MediaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Digite 5 idades abaixo: ");

            WriteLine("===========================");

            WriteLine("Por favor, digite a idade: ");
            var i = int.Parse(ReadLine());

            WriteLine("Por favor, digite a idade: ");
            var j = int.Parse(ReadLine());

            WriteLine("Por favor, digite a idade: ");
            var k = int.Parse(ReadLine());

            WriteLine("Por favor, digite a idade: ");
            var x = int.Parse(ReadLine());

            WriteLine("Por favor, digite a idade: ");
            var y = int.Parse(ReadLine());

            WriteLine("===========================");

            var mediaidades = new Idades(i, j, k, x, y);

            mediaidades.MediaDasIdades();
        }
    }
}
