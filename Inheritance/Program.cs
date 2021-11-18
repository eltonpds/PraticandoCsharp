using Inheritance.Entities;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING - Conversão da Subclasse para a Superclasse
            //A herança signifca que a subclasse é uma superclasse, então a expressão abaixa é referenciada como: BusinessAccount é uma Account
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Console.WriteLine((BusinessAccount)acc2);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.1);
            Console.WriteLine(acc3);

            //DOWNASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //O código abaixo não é permitido pois a acc2 é do tipo Account e o Loan é um método do BusinessAccount
            //acc2.Loan();

            //O compilador exibirá um erro em tempo de execução pois o acc3 é um objeto do tipo SavingsAccount
            //BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;

                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }


            //VIRTUAL E OVERRIDE

            Account acc6 = new Account(1010, "José", 500.0);
            Account acc7 = new SavingsAccount(1011, "Maria", 500.0, 0.01);

            acc6.Withdraw(10.0);
            acc7.Withdraw(10.0);

            Console.WriteLine(acc6.Balance);
            Console.WriteLine(acc7.Balance);

        }
    }
}
