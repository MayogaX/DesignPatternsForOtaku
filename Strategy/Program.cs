using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem principal = new Personagem();
            principal.cavaleiro = new Bronze();

            principal.nome = "Seiya";
            principal.cavaleiro.usaHabilidadeEspecial();

            Console.ReadKey();

            principal.cavaleiro = new Ouro();
            principal.cavaleiro.usaHabilidadeEspecial();

            Console.ReadKey();
        }
    }
}
