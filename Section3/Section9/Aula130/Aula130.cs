using Section9.Aula130.Entities.Enums;
using Section9.Aula130.Entities;
using System;
using System.Globalization;


namespace Section9.Aula130
{
    internal class Aula130
    {
        // Exercício resolvido 01 - PARTE 2/3
        public static void Aula_130()
        {
            Console.Write("Digite o nome do departamento: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Entre os dados do trabalhador:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Nível (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário base: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("Quantos contratos para este trabalhador: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com os dados do {i}o. contrato: ");
                Console.Write("Data (DD/MM/AAAA): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHours = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                Console.Write("Duração (horas): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHours, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Entre com o mês e ano para calcular o ganho (MM/AAAA): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Nome: " + worker.Name);
            Console.WriteLine("Departamento: " + worker.Department.Name);
            Console.WriteLine($"Ganhos para {monthAndYear}: {worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture)}");


        }
    }
}
