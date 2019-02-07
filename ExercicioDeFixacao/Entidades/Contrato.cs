using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao.Entidades
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Prestacao> Prestacaos = new List<Prestacao>();

        public Contrato(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Prestacaos = null;
        }
    }
}
