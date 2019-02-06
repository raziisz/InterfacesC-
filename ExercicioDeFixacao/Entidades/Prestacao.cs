using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao.Entidades
{
    class Prestacao
    {
        public DateTime DataDeVencimento { get; set; }
        public double Valor { get; set; }

        public Prestacao(DateTime dataDeVencimento, double valor)
        {
            DataDeVencimento = dataDeVencimento;
            Valor = valor;
        }
    }
}
