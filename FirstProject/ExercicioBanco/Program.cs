using System;

namespace ExercicioBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco b = new Banco(); 

            Console.Write("Insira o número da conta: ");
            b.setNumConta(int.Parse(Console.ReadLine()));

            Console.Write("\nInsira o nome do titular da conta: ");
            b.setNomeTitular(Console.ReadLine());

            Console.Write("\nDepósito inicial? (s/n): ");
            char opt = char.Parse(Console.ReadLine());

            Console.WriteLine();

            if (opt == 's')
            {
                Console.Write("Insira o valor do primeiro depósito: ");
                b.setValorTotal(double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }
            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta: {b.getNumConta()}, Titular: {b.getNomeTitular()}, Saldo: {b.getValorTotal()}");
            Console.Write("\nInsira o valor do depósito: ");
            b.setValorTotal(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta: {b.getNumConta()}, Titular: {b.getNomeTitular()}, Saldo: {b.getValorTotal()}");
            Console.Write("\nInsira o valor do saque: ");
            b.saqueValor(double.Parse(Console.ReadLine()));
            Console.WriteLine($"Conta: {b.getNumConta()}, Titular: {b.getNomeTitular()}, Saldo: {b.getValorTotal()}");
            Console.Write("\nInsira o valor do saque: ");

        }
    }
}
