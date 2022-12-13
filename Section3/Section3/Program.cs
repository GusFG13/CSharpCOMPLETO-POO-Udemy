namespace Section3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TIPOS BÁSICOS DE DADOS EM C#
            sbyte x = 100; // tipo pré-definido C#
            //SByte x = 100; // tipo .NET precisa incluir using System
            Console.WriteLine(x);

            byte n1 = 255; // de 0 a 255
            //n1 = -1; //erro
            Console.WriteLine(n1);

            int n2 = 1000;
            Console.WriteLine(n2);

            int n3 = 2147483647;
            Console.WriteLine(n3);

            long n4 = 2147483648L;
            Console.WriteLine(n4);

            bool completo = false;
            Console.WriteLine(completo);

            char genero = 'F';
            Console.WriteLine(genero);

            char letra = '\u0041'; //A em unicode
            Console.WriteLine(letra);

            float n5 = 4.5f;
            Console.WriteLine(n5);
            double n6 = 5.6;
            Console.WriteLine(n6);

            string nome = "Gustavo Gonçalves";
            Console.WriteLine(nome);

            object obj1 = "Maria";
            Console.WriteLine(obj1);
            object obj2 = 7.8f;
            Console.WriteLine(obj2);


            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);

            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);
        }
    }
}