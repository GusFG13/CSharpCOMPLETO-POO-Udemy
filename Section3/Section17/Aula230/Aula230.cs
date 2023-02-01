using Section17.Aula230.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section17.Aula230
{
    delegate double BinaryNumericOperation(double n1, double n2);
    internal class Aula230
    {
        public static void Aula_230()
        {
            double a = 10;
            double b = 12;

            //double result = CalculationService.Sum(a, b);
            //double result = CalculationService.Max(a, b);
            //double result = CalculationService.Square(a);
            //Console.WriteLine(result);

            //BinaryNumericOperation op = CalculationService.Sum;
            //BinaryNumericOperation op = CalculationService.Max;
            //BinaryNumericOperation op = CalculationService.Square; //assinatura da funão não corresponde ao declarado no delegate

            //sintaxe alternativa
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);

            //double result = op.Invoke(a, b);
            double result = op(a, b); //equivalente à sintaxe acima
            Console.WriteLine(result);
        }
    }
}
