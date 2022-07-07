using Exception.Exception;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
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

                Console.WriteLine();

                Console.WriteLine("Entre com os dados para atualizar a reserva");

                Console.WriteLine("Escolha a data de check-in");
                DateTime dataEntrada2 = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Escolha a data de check-out");
                DateTime dataSaida2 = DateTime.Parse(Console.ReadLine());

                quarto1.UpdateDate(dataEntrada2, dataSaida2);
                Console.WriteLine("Reservation: " + quarto1);
            }
            catch (DomainException ex)
            {
                Console.WriteLine("Error in reservation: " + ex.Message);
            }

        }
    }
}
