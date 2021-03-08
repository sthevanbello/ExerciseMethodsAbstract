using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseMethodsAbstract.Entities
{
    class Individual : TaxPayer
    {

        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax;


            if (AnualIncome < 20000)
            {
                tax =  AnualIncome * 0.15;
            }
            else
            {
                tax =  AnualIncome * 0.25;
            }

            if (HealthExpenditures != 0)
            {
                tax -= HealthExpenditures * 0.5;
            }

            return tax;
        }

        public override string ToString()
        {
            return $"Name: {Name}\tTax Paid: {Tax().ToString("C")}";
        }
    }
}
