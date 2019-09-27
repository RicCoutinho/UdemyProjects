using System;

namespace ExercicioWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
           while (num >= 0)
            {   
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());
                if (num >= 0) Console.WriteLine("Raíz : " +(Math.Sqrt(num)));

                else Console.WriteLine("Número Negativo!");
            }
        }
    }
}
