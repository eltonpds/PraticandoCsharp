using InheritanceExercise.Model;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace InheritanceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of products: ");
            int numberProducts = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            Console.WriteLine("");

            for (int i = 1; i <= numberProducts; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char typeProduct = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (typeProduct.Equals('i'))
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (typeProduct.Equals('c')) 
                {
                    products.Add(new Product(name, price));
                }
                else
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
            }

            Console.WriteLine("PRICE TAGS: ");
            foreach(Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
