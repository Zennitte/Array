using System;

namespace Exercicio_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome;
            int[] quantidade;
            double[] valor;


            Console.WriteLine("Quantos produtos você quer cadastrar");
            int quantidadeProdutos = int.Parse(Console.ReadLine());

            nome = new string[quantidadeProdutos];
            quantidade = new int[quantidadeProdutos];
            valor = new double[quantidadeProdutos];

            for (var i = 0; i < quantidadeProdutos; i++)
            {
                Console.WriteLine($"Qual o nome do {(i+1)}° produto?");
                nome[i] = Console.ReadLine();
            }

            for (var i = 0; i < quantidadeProdutos; i++)
            {
                Console.WriteLine($"Qual a quantidade do {(i+1)}° produto?");
                quantidade[i] = int.Parse(Console.ReadLine());
            }

            for (var i = 0; i < quantidadeProdutos; i++)
            {
                Console.WriteLine($"Qual o valor do {(i+1)}° produto?");
                valor[i] = double.Parse(Console.ReadLine());
            }
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"| Nome      | Quantidade        | Valor         |");

            for (var i = 0; i < quantidadeProdutos; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($@"| {nome[i]}         |        {quantidade[i]}          |       {valor[i]}       |");                                                                               
            }



            
        }
    }
}
