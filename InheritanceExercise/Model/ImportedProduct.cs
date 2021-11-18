namespace InheritanceExercise.Model
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customseFee) : base(name, price)
        {
            Name = name;
            Price = price;
            CustomsFee = customseFee;
        }

        public override string PriceTag()
        {
            return Name + " (Customs Fee: $ " + CustomsFee + ")";
        }

        public double TotalPrice()
        {
            return Price += CustomsFee;
        }
    }
}
