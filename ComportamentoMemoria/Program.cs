using System;
using System.Collections.Generic;
using System.Globalization;

namespace ComportamentoMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int numberOfEmployees;

            Console.Write("Enter the number of employees: ");
            numberOfEmployees = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            for(int i = 1; i <= numberOfEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)?: ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                
                if (ch.Equals('y'))
                {
                    Console.WriteLine("");
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                } 
                else
                {
                    Console.WriteLine("");
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("PAYMENTS: ");
            foreach(var item in employees)
            {
                Console.WriteLine($"{item.Name} - $ {item.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
