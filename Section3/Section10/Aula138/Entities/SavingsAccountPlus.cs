namespace Section10.Aula138.Entities
{
    // como SavingsAccount é uma classe Sealed
    // SavingsAccountPlus não pode herdar dela
    //class SavingsAccountPlus : SavingsAccount
    //{
    //}

    class SavingsAccountPlus : SavingsAccount
    {
        // se um método for sealed na classe base, ele não pode ser
        // sobre-escrito na classe herdeira
        //public override void Withdraw(double amount)
        //{
        //    Balance -= 2.00;
        //}
    }
}
