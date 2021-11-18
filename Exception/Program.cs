using System;
using System.Runtime.InteropServices.ComTypes;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número do quarto");
            int quartoNum = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Escolha a data de check-in");
            DateTime dataEntrada = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Escolha a data de check-out");
            DateTime dataSaida = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("");

            Reservation quarto1 = new Reservation(quartoNum, dataEntrada, dataSaida);
            Console.WriteLine($"Reservation: {quarto1}");
        }
    }
}
