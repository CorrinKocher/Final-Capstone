namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        public BankAccount (string accountHolderName,string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.Balance = 0;
            this.AccountNumber = accountNumber;

        }

        
        public BankAccount (string accountHolderName, string accountNumber, decimal balance)
        {
            this.Balance = balance;
            this.AccountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
        }

        public string AccountHolderName { get; private set; }

        public string AccountNumber { get; set; }

        public decimal Balance { get; private set; }

        public decimal Deposit (decimal amountToDeposit)
        {
            return this.Balance += amountToDeposit;
        }
        
        public virtual decimal  Withdraw (decimal amountToWithdraw)
        {
            this.Balance = this.Balance - amountToWithdraw;
            return Balance;
        }


    }
}
