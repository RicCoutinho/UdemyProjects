using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao3
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public override string ToString()
        {
            if (Nota1 + Nota2 + Nota3 >= 60)
            {
                return "NOTA FINAL: " + (Nota1 + Nota2 + Nota3).ToString("F2") + "\nAPROVADO!";
            }
            else
            {
                double m = 60 - (Nota1 + Nota2 + Nota3);
                return "REPROVADO!\nFALTARAM: " + m.ToString("F2") + "PONTO(S)";
            }
        }
    }
}
