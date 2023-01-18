namespace ExampleAbstractClass.Entities
{
    public class Developer : Employee
    {
        public override void Readjustment()
        {
            Salary += 1000;
        }
    }
}
