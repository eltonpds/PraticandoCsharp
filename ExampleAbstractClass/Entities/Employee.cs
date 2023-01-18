namespace ExampleAbstractClass.Entities
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public abstract void Readjustment();
    }
}
