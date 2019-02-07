

namespace ExercicioDeFixacao.Servicos
{
    interface IServicoPagamento
    {
         double TaxaDePagament(double valor);
        double Interesse(double valor, int meses);
    }
}
