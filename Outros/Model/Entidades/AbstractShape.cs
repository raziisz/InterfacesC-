using Outros.Model.Enum;

namespace Outros.Model.Entidades
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        protected AbstractShape(Color color)
        {
            Color = color;
        }

        abstract public double Area();
        
    }
}
