using Section9.Aula132.Entities;
using Section9.Aula132.Entities.Enums;
using System.Globalization;
using System.Reflection.Emit;

namespace Section9.Aula132
{
    internal class Aula132
    {
        // Exercício proposto (Enumerações e Composição)
        public static void Aula_132()
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status =  Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int numItems = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            for (int i = 1; i <= numItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prodtName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int prodQuantity = int.Parse(Console.ReadLine());
                Product product = new Product(prodtName, prodPrice);
                OrderItem item = new OrderItem(prodQuantity, prodPrice, product);
                order.AddItem(item);
            }
            Console.WriteLine();
            Console.WriteLine(order.ToString());
        }
    }
}
