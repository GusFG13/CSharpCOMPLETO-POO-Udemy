using System;
using System.Globalization;


namespace Section14.Aula208.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyy", CultureInfo.InvariantCulture)
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
