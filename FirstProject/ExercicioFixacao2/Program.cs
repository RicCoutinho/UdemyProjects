using System;

namespace ExercicioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.WriteLine("Insira os dados do Funcionario: ");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Funcionário: "+f.Nome+", Salário: R$" +f.SalarioLiquido().ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            f.AumentarSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: ");
            Console.Write("Nome: "+f.Nome+ ", Salário: R$" +f.SalarioLiquido().ToString("F2"));
        }
    }
}
