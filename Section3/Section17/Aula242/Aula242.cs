using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Section17.Aula242.Entities;

namespace Section17.Aula242
{
    class Aula242
    {
        /*
            Fazer um programa para ler os dados (nome, email e salário)
            de funcionários a partir de um arquivo em formato .csv.
            Em seguida mostrar, em ordem alfabética, o email dos
            funcionários cujo salário seja superior a um dado valor
            fornecido pelo usuário.
            Mostrar também a soma dos salários dos funcionários cujo
            nome começa com a letra 'M'.

                +------------------+
                |     Employee     |
                +------------------|
                | - name: String   |
                | - email: String  |
                | - salary: Double |
                +------------------+

            Input file:
                Maria,maria@gmail.com,3200.00
                Alex,alex@gmail.com,1900.00
                Marco,marco@gmail.com,1700.00
                Bob,bob@gmail.com,3500.00
                Anna,anna@gmail.com,2800.00

            Execution:
                Enter full file path: c:\temp\in.txt
                Enter salary: 2000.00
                Email of people whose salary is more than 2000.00:
                anna@gmail.com
                bob@gmail.com
                maria@gmail.com
                Sum of salary of people whose name starts with 'M': 4900.00
         */
        public static void Aula_242()
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double employeeSalary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, employeeSalary));
                }
            }

            Console.WriteLine($"Email of people whose salary is more than {salary.ToString("F2", CultureInfo.InvariantCulture)}:");
            var emailsOfTargetSalary = list.Where(p => p.Salary > salary).OrderBy(p => p.Email).Select(p => p.Email);
            foreach (string e in emailsOfTargetSalary)
            {
                Console.WriteLine(e);
            }
            double sumSalary = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sumSalary.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
        }
    }
}
