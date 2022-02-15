using System;

namespace MediaIdade
{
    public class Idades
    {
        public Idades(int idade1, int idade2, int idade3, int idade4, int idade5)
        {
            Idade1 = idade1;
            Idade2 = idade2;
            Idade3 = idade3;
            Idade4 = idade4;
            Idade5 = idade5;
        }

        
        private int Idade1 { get; set; }
        private int Idade2 { get; set; }
        private int Idade3 { get; set; }
        private int Idade4 { get; set; }
        private int Idade5 { get; set; }
        public int Media { get; set; }
        
        public void MediaDasIdades()
        {
            Media = (Idade1 + Idade2 + Idade3 + Idade4 + Idade5) / 5;

            Console.WriteLine($"A média das idades é: {Media} anos.");
        }

    }
}