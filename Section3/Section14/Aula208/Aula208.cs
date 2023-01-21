using Section14.Aula208.Entities;
using Section14.Aula208.Services;
using System;
using System.Globalization;
namespace Section14.Aula208
{
    internal class Aula208
    {
        /*
            Uma empresa deseja automatizar o processamento de seus contratos. O processamento de
            um contrato consiste em gerar as parcelas a serem pagas para aquele contrato, com base no
            número de meses desejado.

            A empresa utiliza um serviço de pagamento online para realizar o pagamento das parcelas.
            Os serviços de pagamento online tipicamente cobram um juro mensal, bem como uma taxa
            por pagamento. Por enquanto, o serviço contratado pela empresa é o do Paypal, que aplica
            juros simples de 1% a cada parcela, mais uma taxa de pagamento de 2%.

            Fazer um programa para ler os dados de um contrato (número do contrato, data do contrato,
            e valor total do contrato). Em seguida, o programa deve ler o número de meses para
            parcelamento do contrato, e daí gerar os registros de parcelas a serem pagas (data e valor),
            sendo a primeira parcela a ser paga um mês após a data do contrato, a segunda parcela dois
            meses após o contrato e assim por diante. Mostrar os dados das parcelas na tela.

            Exemplo:

            Enter contract data
            Number: 8028
            Date (dd/MM/yyyy): 25/06/2018
            Contract value: 600.00
            Enter number of installments: 3
            Installments:
            25/07/2018 - 206.04
            25/08/2018 - 208.08
            25/09/2018 - 210.12

         */
        public static void Aula_208()
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int numInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, totalValue);
            ContractService contractService = new ContractService(new PaypalService());

            
            Console.WriteLine("Installments:");
            contractService.ProcessContract(contract, numInstallments);

        }

        /*
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
          
         */
    }
}
