using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioBanco
{
    class Banco
    {
        private int _numConta;
        private string _nomeTitular;
        private double _valorTotal;
        private double _saqueValor;

        public int getNumConta()
        {
            return _numConta;
        }
        public void setNumConta(int numConta)
        {
            _numConta = numConta;
        }
        public string getNomeTitular()
        {
            return _nomeTitular;
        }
        public void setNomeTitular(string nomeTitular)
        {
            _nomeTitular = nomeTitular;
        }
        public double getValorTotal()
        {
            return _valorTotal;
        }
        public void setValorTotal(double valorTotal)
        {
            _valorTotal += valorTotal;
        }

        public void saqueValor(double valor)
        {
            _valorTotal -= valor;
        }

    }
}
