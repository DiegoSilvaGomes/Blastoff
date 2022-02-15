// 12 - Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a concatenação das listas.


using System;
using System.Collections.Generic;
using System.Linq;

namespace Concatenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int>() {1,2,3,4};
            var b = new List<int>() {1,2,5,8};
            var c = a.Concat(b);

            foreach(var contador in c)
                Console.WriteLine(contador);
        }
    }
}
