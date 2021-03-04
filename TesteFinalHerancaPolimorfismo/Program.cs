using System;
using System.Collections.Generic;
using System.Globalization;
using TesteFinalHerancaPolimorfismo.Entities;

namespace TesteFinalHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> payers = new List<TaxPayer>();
            
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    payers.Add(new Individual(name, anualIncome, healthExpenditures));
                }

                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    payers.Add(new Company(name, anualIncome, numberOfEmployees));
                } 
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer payer in payers)
            {
                Console.WriteLine(payer);
                sum += payer.Tax();
            }

            Console.WriteLine($"\nTOTAL TAXES: {sum.ToString("C2")}");
        }
    }
}
