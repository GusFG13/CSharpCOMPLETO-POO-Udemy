using System.Globalization;

namespace Section14.Aula209.Model.Entities
{
    //class Rectangle : Shape
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", width = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
