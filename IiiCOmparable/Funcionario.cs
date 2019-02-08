using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace IiiCOmparable
{
    class Funcionario : IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string n)
        {
            string[] x = n.Split(',');
            Nome = x[0];
            Salario = double.Parse(x[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return "Nome: " + Nome
                + "\nSalario: " + Salario.ToString("F2",CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Funcionario))
            {
                throw new ArgumentException("Comparing error: argument is not an Funcionario");
            }
            Funcionario other = obj as Funcionario;
            return Salario.CompareTo(other.Salario);
        }
    }
}
