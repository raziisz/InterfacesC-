using Outros.Model.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Outros.Model.Entidades
{
    class Retangulo : AbstractShape
    {
        public double  Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Color color) 
            : base(color)
        {
            Largura = largura;
            Altura = altura;
        }
        public override string ToString()
        {
            return "A cor do Retangulo é: " + Color
                + "E sua area: " + Area();
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
