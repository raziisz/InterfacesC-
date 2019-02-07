using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacao.Servicos
{
    class PayPal : IServicoPagamento
    {
        public double Interesse(double valor, int meses)
        {

            return valor + (valor * 0.01) * meses;
            
        }

        public double TaxaDePagament(double valor)
        {
            return valor + (valor * 0.02);
        }
    }
}
