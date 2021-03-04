namespace TesteFinalHerancaPolimorfismo.Entities
{
    class Individual : TaxPayer
    {
        public double HeaithExpenditures { get; set; }

        public Individual(string name, double anualIncome, double heaithExpenditures) : base(name, anualIncome)
        {
            HeaithExpenditures = heaithExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {

                return AnualIncome * 0.15 - HeaithExpenditures * 0.50; ;
            }

            else
            {

                return AnualIncome * 0.25 - HeaithExpenditures * 0.50;
            }
        }
    }
}
