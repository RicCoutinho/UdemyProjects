using System;
using System.Globalization;

namespace ExercicioFixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre com a altura e a largura de um retângulo: ");
            r.Altura = double.Parse(Console.ReadLine());
            r.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine("ÁREA =  " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO =  " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL =  " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
