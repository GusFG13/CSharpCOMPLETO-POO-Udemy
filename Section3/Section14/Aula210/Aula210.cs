
using Section14.Aula210.Devices;

namespace Section14.Aula210
{
    internal class Aula210
    {
        public static void Aula_210()
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

        }
    }
}
