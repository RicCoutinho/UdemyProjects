using System;
using System.Globalization;
namespace Input2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            char ch;
            double n2;

            n1 = int.Parse(Console.ReadLine());
            ch = char.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            string[] vet = Console.ReadLine().Split(' ');
            Console.WriteLine("Inteiro: " +n1+ " Char: " +ch+ " Double: " +n2);
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            float altura = float.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine($"Nome: {nome} , Sexo: {sexo}, Idade: {idade}, Altura: {altura:F1}. ");
        }
    }
}
