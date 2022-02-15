using static System.Console;
using System;

namespace Combustivel
{
    public class Menu
    {
        public static void Show()
        {
            Clear();

            WriteLine("Vamos calcular o combustivel gasto durante a sua viagem. Por favor, informe os dados abaixo: ");

            WriteLine("A distância gasta na viagem: ");
            var distancia = double.Parse(Console.ReadLine());

            WriteLine("O combustível utilizado: ");
            var combustivel = double.Parse(Console.ReadLine());

            Calculo(distancia, combustivel);

        }

        public static void Calculo(double distancia, double combustivel)
        {

            var MediaLitrosUsados = distancia / combustivel;

            WriteLine("Dados: ");
            WriteLine($"Distância percorrida: {distancia} Km");
            WriteLine($"O consumo médio de combustivel utilizado foi de: {MediaLitrosUsados} litros");
        }

    }
}

