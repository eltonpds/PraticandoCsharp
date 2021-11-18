namespace Inheritance.Entities
{
    public class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            // A implementação abaixo é realizada implicitamente ao passar as propriedades do objeto por parâmetro no base()
            //Number = number;
            //Holder = holder;
            //Balance = balance;
            LoanLimit = loanLimit;
        }
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
                Balance += amount;
        }
    }
}
