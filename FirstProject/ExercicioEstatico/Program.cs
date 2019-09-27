using System;
using System.Globalization;

namespace ExercicioEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            double qtd = double.Parse(Console.ReadLine());

            Console.Write("Valor a ser pago em reais: R$ " 
                + ConversorDeMoeda.Conversor(valor, qtd).ToString("F2", CultureInfo.InvariantCulture));


            
        }
    }
}
