using static System.Console;
using System;

namespace MenorNumero
{
    public class Menu
    {
        public static void show()
        {
            Clear();

            WriteLine("Digite 3 números, por favor: ");

            WriteLine("------------------------------");

            WriteLine("Digite um número: ");
            var a = int.Parse(ReadLine());

            WriteLine("Digite um número: ");
            var b = int.Parse(ReadLine());

            WriteLine("Digite um número: ");
            var c = int.Parse(ReadLine());

            Validacao(a, b, c);
        }

        public static void Validacao(int a, int b, int c)
        {
            if(a <= b && a <= c)
                WriteLine($"O menor número é: {a}");
            else if(b <= a && b <= c)
                WriteLine($"O menor número é: {b}");               
            else
                WriteLine($"O menor número é: {c}");
        }
    }
}