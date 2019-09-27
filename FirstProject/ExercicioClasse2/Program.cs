using System;
using System.Globalization;

namespace ExercicioClasse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine());
            Console.Write("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine());
            double medio = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine($"Salário Médio: " +medio.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
