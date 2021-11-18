namespace Inheritance.Entities
{
    //Sealed neste contexto é utilizado para evitar que a classe SavingsAccount seja herdada por outra classe
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        //A palavra sealed neste contexto impede que o método abaixo seja sobrescrita novamente
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
