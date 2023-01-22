
using Section14.Aula210b.Devices;

namespace Section14.Aula210b
{
    internal class Aula210b
    {
        public static void Aula_210b()
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());

        }
    }
}
