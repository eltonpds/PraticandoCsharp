using System;

namespace InheritanceExercise.Model
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            Name = name;
            Price = price;
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }

    }
}
