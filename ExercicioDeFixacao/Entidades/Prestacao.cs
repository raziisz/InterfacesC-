using System;
using System.Collections.Generic;
using System.Globalization;
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

        public override string ToString()
        {
            return DataDeVencimento.ToString("dd/MM/yyyy") + " - " + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
