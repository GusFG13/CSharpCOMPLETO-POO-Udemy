using Section14.Aula209.Model.Enums;

namespace Section14.Aula209.Model.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
