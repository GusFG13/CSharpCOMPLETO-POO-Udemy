namespace Section7
{
    internal class Aula85
    {
        // Inferência de tipos: palavra var
        public static void Aula_85()
        {
            //int x = 10;
            var x = 10;
            var y = 20.0;
            var z = "Maria";

            var a = z;
            //int b = z;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
