using Outros.Model.Entidades;
using System;

namespace Outros
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape f1 = new Circulo(2.0, Model.Enum.Color.Black);

            Console.WriteLine(f1);
        }
    }
}
