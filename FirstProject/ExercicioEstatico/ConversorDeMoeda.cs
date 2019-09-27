using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEstatico
{
    class ConversorDeMoeda
    {
        public static double Conversor(double valor, double qtd)
        {
            return valor * qtd + (((valor * qtd) *6) / 100 );
        }
    }
}
