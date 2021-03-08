using ExerciseMethodsAbstract.Entities;
using System;
using System.Collections.Generic;

namespace ExerciseMethodsAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> payers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: \n");

                Console.Write("Individual or Company (i/c)? : ");
                string type = Console.ReadLine().ToLower();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (type == "i")
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    payers.Add(new Individual(name, anualIncome, healthExpenditures));

                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    payers.Add(new Company(name, anualIncome, employees));


                }

            }
            Console.WriteLine("\nTAXES PAID:\n");
            double sum = 0;

            foreach (TaxPayer item in payers)
            {

                Console.WriteLine(item.ToString());
                sum += item.Tax();
            }

            Console.WriteLine($"\n\tTOTAL TAXES: {sum.ToString("C")}");





            Console.ReadKey();
        }
    }
}
