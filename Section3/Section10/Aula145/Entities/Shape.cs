using Section10.Aula145.Entities.Enums;

namespace Section10.Aula145.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color) 
        {
            Color = color;
        }

        public abstract double Area();

    }
}
