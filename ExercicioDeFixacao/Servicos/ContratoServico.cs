using ExercicioDeFixacao.Entidades;
using System;
using System.Globalization;

namespace ExercicioDeFixacao.Servicos
{
    class ContratoServico
    {
        private IServicoPagamento _servicoPagamento;

        public ContratoServico(IServicoPagamento servicoPagamento)
        {
            _servicoPagamento = servicoPagamento;
        }

        public  void ProcessoContrato(Contrato contrato, int meses)
        {
           double  valor = contrato.ValorTotal / meses;
           

            for (int i = 1; i <= meses; i++)
            {
                double valor1 = _servicoPagamento.Interesse(valor, i);
                DateTime dt = contrato.Data.AddMonths(i);
                double valorTotal = _servicoPagamento.TaxaDePagament(valor1);
                contrato.AddPrestacao(new Prestacao(dt, valorTotal));
               
            }
  
        }

    }
}
