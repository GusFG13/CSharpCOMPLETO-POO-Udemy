using System;

namespace Section14.Aula208.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount * 1.02;
        }
        public double Interest(double amount, int months)
        {
            return amount * (1 + (0.01 * months));
        }

    }
}
