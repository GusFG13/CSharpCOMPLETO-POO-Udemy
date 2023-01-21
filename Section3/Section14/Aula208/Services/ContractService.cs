using System;
using Microsoft.VisualBasic;
using Section14.Aula206.Services;
using Section14.Aula208.Entities;

namespace Section14.Aula208.Services
{
    class ContractService
    {

        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {

            double amount = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                double interest = _onlinePaymentService.Interest(amount, i);
                double paymentFee = _onlinePaymentService.PaymentFee(interest); 
                contract.Instalments = new Installment(contract.Date.AddMonths(i), paymentFee);
                Console.WriteLine(contract.Instalments);
            }
        }

        /*
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
         */
    }
}
