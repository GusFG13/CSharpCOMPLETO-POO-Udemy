using Section14.Aula209.Model.Entities;
using Section14.Aula209.Model.Enums;

namespace Section14.Aula209
{
    internal class Aula209
    {
        public static void Aula_209()
        {
            //Shape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            //Shape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
