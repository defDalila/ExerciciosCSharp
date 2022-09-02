using System.Globalization;
using ListaDePedidos.Entities;
using ListaDePedidos.Entities.Enums;

namespace ListaDePedidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Client client = new Client()
            {
                Name = name,
                BirthDate = birthDate,
                Email = email
            };

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order()
            {
                Client = client,
                Moment = DateTime.Now,
                Status = status
            };

            Console.Write("How many items to this order? ");
            int qtdade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < qtdade; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();

                Console.Write("Product Price: $ ");
                double price = double.Parse(Console.ReadLine(),
                    CultureInfo.InvariantCulture);

                Product product = new Product()
                {
                    Name = nameProduct,
                    Price = price
                };

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine();

                OrderItem item = new OrderItem()
                {
                    Product = product,
                    Quantity = quantity,
                    Price = price
                };

                order.AddItem(item);
            }

            Console.WriteLine(order);
        }
    }
}