﻿
namespace CalculoImposto.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome,double healthExpenditures)
            :base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double limitValue = 20000.00;
            double tax = 0.0;
            if (AnualIncome < limitValue)
            {
                tax = AnualIncome * 0.15;
            }
            else
            {
                tax = AnualIncome * 0.25;
            }
            

            return tax - HealthExpenditures * 0.50;
        }
    }
}
