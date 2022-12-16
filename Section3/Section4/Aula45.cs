using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics.Metrics;

namespace Section4
{
    internal class Aula45
    {
        public static void Ex1()
        {
            // Fazer um programa para ler os valores da largura e altura de um retângulo. Em
            // seguida, mostrar na tela o valor de sua área, perímetro e diagonal.Usar uma classe
            // como mostrado no projeto ao lado.

            /* 
             *    +-----------------------+
             *    |       Retângulo       |
             *    +-----------------------+
             *    | - Largura: double     |
             *    | - Altura: double      |
             *    +-----------------------+
             *    | + Area(): double      |
             *    | + Perimetro(): double |
             *    | + Diagonal(): double  |
             *    +-----------------------+
             */

            Retangulo ret = new Retangulo();
            Console.Write("Digite a largura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a altura do retângulo: ");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"ÁREA = {ret.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO = {ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void Ex2()
        {
            // Fazer um programa para ler os dados de um funcionário(nome,
            // salário bruto e imposto). Em seguida, mostrar os dados do
            // funcionário(nome e salário líquido).Em seguida, aumentar o salário
            // do funcionário com base em uma porcentagem dada(somente o
            // salário bruto é afetado pela porcentagem) e mostrar novamente os
            // dados do funcionário.Use a classe projetada abaixo.

            /* 
             *    +----------------------------------------------+
             *    |                  Funcionário                 |
             *    +----------------------------------------------+
             *    | - Nome: string                               |
             *    | - SalarioBruto: double                       |
             *    | - Imposto: double                            |
             *    +----------------------------------------------+
             *    | + SalarioLiquido(): double                   |
             *    | + AumentarSalario(porcentagem: double): void |
             *    +----------------------------------------------+
             */

            FuncionarioA45Ex2 func = new FuncionarioA45Ex2();
            Console.WriteLine("Digite os dados do funcionário:");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nFuncionário: " + func);

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double pct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            func.AumentarSalario(pct);
            Console.WriteLine("\nDados atualizados: " + func);
        }
        public static void Ex3()
        {
            // Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
            // (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada).Ao final, mostrar qual a nota final do aluno no
            // ano.Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
            // para o aluno obter o mínimo para ser aprovado(que é 60 pontos). Você deve criar uma classe Aluno para resolver
            // este problema.
            AlunoA45Ex3 aluno = new AlunoA45Ex3();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");

            Console.Write($"Nota primeiro trimestre: ");
            aluno.NotaPrimeiroTrim = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"Nota segundo trimestre: ");
            aluno.NotaSegundoTrim = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"Nota terceiro trimestre: ");
            aluno.NotaTerceiroTrim = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"\nNOTAFINAL = {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(aluno.StatusAluno());
        }
    }
}
