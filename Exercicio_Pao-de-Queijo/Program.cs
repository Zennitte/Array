using System;

namespace Exercicio_Pao_de_Queijo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] paoDeQueijo;

            Console.WriteLine("Quantas embalagens de pão de queijo tem na prateleira");
            int quantidadeEmbalagens = int.Parse(Console.ReadLine());

            paoDeQueijo = new int[quantidadeEmbalagens];

            for (var i = 0; i < quantidadeEmbalagens; i++)
            {
                Console.WriteLine($"Digite a quantidade de pão de queijo da {(i+1)}ª embalagem");
                paoDeQueijo[i] = int.Parse(Console.ReadLine());
            }

            int c = 1;
            foreach (var item in paoDeQueijo)
            {
                Console.WriteLine($"A {c}ª emabalgem tem: {item} pães de queijo");
            }
        }
    }
}
