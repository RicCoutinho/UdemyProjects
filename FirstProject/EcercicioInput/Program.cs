using System;

namespace EcercicioInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço  de um produto: ");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com seu último nome, sua idade e sua altura, na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');
            string lastName = vet[0];
            int age = int.Parse(vet[1]);
            float height = float.Parse(vet[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine($"{preco:F2}");
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine($"{height:F2}");
        }
    }
}
