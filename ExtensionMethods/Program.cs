using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataAtual = DateTime.Now;

            Console.WriteLine(dataAtual.ToBrazilianFormat());
            Console.ReadKey();
        }
    }
}
