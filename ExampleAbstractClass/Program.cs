using ExampleAbstractClass.Entities;
using System;

namespace ExampleAbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer();
            Designer designer = new Designer();

            developer.Salary = 1300M;
            Console.WriteLine("Calculating developers readjustment\n");
            developer.Readjustment();
            Console.WriteLine("Developers new salary {0}", developer.Salary);

            designer.Salary = 1100M;
            Console.WriteLine("\nCalculating designers readjustment");
            designer.Readjustment();
            Console.WriteLine($"Designers new salary {designer.Salary}");

            Console.ReadKey();
        }
    }
}
