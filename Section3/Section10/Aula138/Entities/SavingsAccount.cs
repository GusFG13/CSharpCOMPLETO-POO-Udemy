namespace Section10.Aula138.Entities
{
    //sealed class SavingsAccount : Account
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += (Balance * InterestRate);
        }

        // sobre-escreve o método da classe base para não cobrar a taxa de saque
        //public override void Withdraw(double amount)
        //{
        //    Balance -= amount;
        //}

        // sobre-escreve o método da classe base, mas executa o mpetodo original normalmente
        // com "base.Withdraw" e retira mais uma taxa de 2.00
        // com sealed, método não pode ser sobreescrito em outra classe
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.00;
        }

    }
}
