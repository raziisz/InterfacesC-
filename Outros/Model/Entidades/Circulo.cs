using Outros.Model.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Outros.Model.Entidades
{
    class Circulo : AbstractShape
    {
        public double Raio { get; set; }

        public Circulo(double raio, Color color) : base(color)
        {
            Raio = raio;
        }

        public override string ToString()
        {
            return "A cor do seu circulo é: "+Color+
                " e a area do circulo é: "+Area();
        }

        public override double Area()
        {
            return Raio* Raio * Math.PI;
        }

    }
}
