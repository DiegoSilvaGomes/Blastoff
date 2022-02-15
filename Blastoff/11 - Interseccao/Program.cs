// 11 - Dada duas lista de números A[1,2,3,4] e B[1,2,5,8], faça um algoritmo que retorne a intersecção das listas

using System;
using System.Collections.Generic;

namespace Interseccao
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int>() {1, 2, 3, 4};
            var b = new List<int>() {1, 2, 5, 8};
            var c = new List<int>();

            for (var i = 0; i < a.Count; i++)
            {
                for (var j = 0; j < b.Count; j++)
                {
                    if (a[i] == b[j])
                    {
                        c.Add(a[i]);
                    }
                         
                }
            }

            foreach(var intersec in c)
            {
                Console.WriteLine(intersec);
            }
        }
    }
}
