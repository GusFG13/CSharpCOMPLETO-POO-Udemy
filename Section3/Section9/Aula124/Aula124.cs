using Section9.Aula124.Entities.Enums;
using Section9.Aula124.Entities;

namespace Section9.Aula124
{
    internal class Aula124
    {
        // Enumerações (enum)
        public static void Aula_124()
        {
            Order order = new Order()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}
