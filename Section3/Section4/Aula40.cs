using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Section4
{
    internal class Aula40
    {
        public static void Ex1() 
        {
            PessoaA40Ex1 p1 = new PessoaA40Ex1();
            PessoaA40Ex1 p2 = new PessoaA40Ex1();
            Console.Write("Digite o nome da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            p1.idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            Console.Write("Digite a idade da segunda pessoa: ");
            p2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine($"Nome: {p1.nome}");
            Console.WriteLine($"Idade: {p1.idade}");
            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine($"Nome: {p2.nome}");
            Console.WriteLine($"Idade: {p2.idade}");
            if (p1.idade > p2.idade)
                Console.WriteLine($"Pessoa mais velha: {p1.nome}");
            else if (p1.idade < p2.idade)
                Console.WriteLine($"Pessoa mais velha: {p2.nome}");
            else
                Console.WriteLine("Mesma idade.");
        }
        public static void Ex2()
        {
            FuncionarioA40Ex2 f1 = new FuncionarioA40Ex2();
            FuncionarioA40Ex2 f2 = new FuncionarioA40Ex2();
            Console.Write("Digite o nome do primeiro funcionário: ");
            f1.nome = Console.ReadLine();
            Console.Write("Digite o salário do primeiro funcionário: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o nome do segundo funcionário: ");
            f2.nome = Console.ReadLine();
            Console.Write("Digite o salário do segundo funcionário: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.WriteLine($"Nome: {f1.nome}");
            Console.WriteLine($"Salário: {f1.salario}");
            Console.WriteLine("Dados do segundo funcionário:");
            Console.WriteLine($"Nome: {f2.nome}");
            Console.WriteLine($"Salário: {f2.salario}");
            Console.WriteLine($"Salário médio = {((f1.salario + f2.salario) / 2).ToString("F2", CultureInfo.InvariantCulture)}");
        
        }
    }
}
