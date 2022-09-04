using System.Globalization;
using CalculoImposto.Entities;

namespace CalculoImposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax Payer #{i + 1} data: ");
                Console.Write("Individual or Company (i/c) ? ");
                string option = Console.ReadLine().ToUpper();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual Income: $ ");
                double anualIncome = double.Parse(Console.ReadLine(),
                    CultureInfo.InvariantCulture);

                if (option == "I")
                {
                    Console.Write("Health Expenditures: $ ");
                    double healthExpenditures = double.Parse(Console.ReadLine(),
                        CultureInfo.InvariantCulture);

                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }

                Console.WriteLine();
            }


            Console.WriteLine("TAXES PAID");
            double totalTaxes = 0.0;
            foreach(TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTaxes += taxPayer.Tax();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}