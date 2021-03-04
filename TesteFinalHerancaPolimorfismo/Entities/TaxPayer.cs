﻿namespace TesteFinalHerancaPolimorfismo.Entities
{
    public abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return $"Name: {Name} {Tax().ToString("C2")}";
        }
    }
}
