/*6 - Uma partida de futebol iniciou na hora A e terminou na hora B. Faça um algoritmo que
calcule o tempo que durou a partida.*/

using static System.Console;
using System;

namespace TempoPartida
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();

            WriteLine("Digite a hora que o jogo iniciou: ");
            var a = double.Parse(ReadLine());

            WriteLine("Digite a hora que o jogo terminou: ");
            var b = double.Parse(ReadLine());

            var duracaoPartida = b - a;

            WriteLine($"A partida durou um total de {duracaoPartida}h.");
        }
    }
}
