using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section17.Aula229
{
    internal class Aula229
    {

        public static int globalValue = 3;
        public static void Aula_229()
        {
            int[] vect = new int[] { 3, 4, 5 };
            ChangeOddValues(vect);
            Console.WriteLine(string.Join(" ", vect));
        }

        public static void ChangeOddValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalValue;
                }
            }
        }
    }
}
