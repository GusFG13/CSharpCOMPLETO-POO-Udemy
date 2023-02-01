using System;
using Section17.Aula231.Services;


namespace Section17.Aula231
{
    delegate void BinaryNumericOperation(double n1, double n2);
    internal class Aula231
    {
        public static void Aula_231()
        {
            double a = 10;
            double b = 12;
            BinaryNumericOperation op = CalculationService.ShowSum;
            //op.Invoke(a, b);
            op(a, b);
            Console.WriteLine("******");
            op += CalculationService.ShowMax;
            //op.Invoke(a, b);
            op(a, b);
        }
    }
}
