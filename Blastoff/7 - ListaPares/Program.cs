/*7 - Dada uma lista de números A[1,2,3,…], faça um algoritmo que retorne uma lista somente com os números pares.*/

using System;
using static System.Console;
using System.Collections.Generic;

namespace ListaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new List<Pares>();
            int num;
            
            WriteLine("Deseja adicionar quantos números na lista?");
            var cont = int.Parse(ReadLine());

            for(var i = 0; i < cont; i++)
            {
                WriteLine("Digite o número para adicionar na lista: ");
                num = int.Parse(ReadLine());
                a.Add(new Pares(num));
            }

            Clear();

            foreach(var par in a)
            {
                if(par.Par % 2 == 0)
                    WriteLine(par.Par);
            }
        }
    }

    public class Pares 
    {
        public Pares(int num)
        {
            Par = num;
        }
        public int Par { get; set; }
    }
    
}
