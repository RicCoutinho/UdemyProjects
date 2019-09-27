using System;

namespace PrimeiroProblema
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.Write("Insira o nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Insira o preço do produto: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Insira a quantidade do produto: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(p);
            p.AdicionarProdutos(2);
            p.RemoverProdutos(1);
            Console.WriteLine(p);

        }
    }
}
