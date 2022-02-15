using static System.Console;
using System;

namespace Temperatura
{
    public class Menu
    {
        public static void Show()
        {
           WriteLine("Digite a valor da temperatura em graus celsius(Cº):"); 
           var c = int.Parse(ReadLine());

           var f = ((9 * c) + 160) / 5;

           WriteLine($"A temperatura em graus Fahrenheit é: {f}º");
        }
    }
}