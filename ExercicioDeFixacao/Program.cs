using ExercicioDeFixacao.Entidades;
using ExercicioDeFixacao.Servicos;
using System;
using System.Globalization;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double total = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int meses = int.Parse(Console.ReadLine());

            

            Contrato ctt = new Contrato(cod, data, total);

            ContratoServico cs = new ContratoServico(new PayPal());
            Console.WriteLine("Installments:");
            cs.ProcessoContrato(ctt, meses);

            foreach (var prestacao in ctt.Prestacaos)
            {
                Console.WriteLine(prestacao);
            }
            
        }
    }
}
