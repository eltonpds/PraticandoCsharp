using ExceptionExercise.Entities;
using ExceptionExercise.Entities.Exceptions;
using System;
using System.Globalization;

namespace ExceptionExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter account number: ");
                int accountNumber = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                double withdrawLimite = double.Parse(Console.ReadLine());

                Account acc = new Account(accountNumber, holder, initialBalance, withdrawLimite);

                Console.Write("Enter the amount to deposit: ");
                double amountToDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.Deposit(amountToDeposit);

            try
            {
                Console.Write("Enter number to withdraw: ");
                double amountToWithdraw = double.Parse(Console.ReadLine());
                acc.Withdraw(amountToWithdraw);

                Console.WriteLine("New balance: R$" + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
