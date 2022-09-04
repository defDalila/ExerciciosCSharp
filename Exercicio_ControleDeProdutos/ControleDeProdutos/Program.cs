using System.Globalization;
using System.Collections.Generic;
using ControleDeProdutos.Entities;

namespace ControleDeProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Product> products = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");

                Console.Write("Common, used or imported (c/u/i)? ");
                string opcao = Console.ReadLine().ToUpper();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: $ ");
                double price = double.Parse(Console.ReadLine(), 
                    CultureInfo.InvariantCulture);

                if (opcao == "U")
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    UsedProduct product = new UsedProduct(name, price, date);
                    products.Add(product);
                }

                else if (opcao == "I")
                {
                    Console.Write("Customs fee: $ ");
                    double customs = double.Parse(Console.ReadLine(),
                        CultureInfo.InvariantCulture);

                    ImporteProduct product = new ImporteProduct(name, price, customs);
                    products.Add(product);
                }

                else
                {
                    Product product = new Product(name, price);
                    products.Add(product);
                }
                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS:");
            foreach(Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}