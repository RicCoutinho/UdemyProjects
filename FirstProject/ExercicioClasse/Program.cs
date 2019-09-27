using System;

namespace ExercicioClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x = new Pessoa();
            Pessoa y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.Idade = int.Parse(Console.ReadLine());

            if (x.Idade > y.Idade)
                Console.WriteLine("Pessoa mais velha: " +x.Nome);
            else
                Console.WriteLine("Pessoa mais velha: " +y.Nome);
        }
    }
}
