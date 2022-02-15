// 13 - Faça um algoritmo que receba uma matriz[i,z] como parâmetro e imprima todos os valores dessa matriz.

using System;
using static System.Console;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            var matriz = new int[4,2] { { 11, 57 }, { 22, 8 }, { 10, 1 }, { 16, 4 } };

            foreach(var i in matriz)
            {
                WriteLine(matriz[i,i]);
            }
        }
    }
}
