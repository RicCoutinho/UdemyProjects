using System;
using System.Collections.Generic;
using System.Text;
namespace PrimeiroProblema
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProdutos(int qtd)
        {
            Quantidade = Quantidade - qtd;
        }
        public override string ToString()
        {
            return $"Produto: {Nome}\nPreço: {Preco}" + 
                $"\nQuantidade: {Quantidade}" +
                $"\nValor total no estoque {Preco * Quantidade:F2}";
        }
    }
}
