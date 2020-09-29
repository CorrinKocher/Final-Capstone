namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        private decimal amountToWithdraw;
        public CheckingAccount(string accountHolderName, string accountNumber) : base (accountHolderName, accountNumber)
        {

        }
        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {
           
        }

        public override decimal Withdraw(decimal amountToWithdraw) //: base.Withdraw(amountToWithdraw) <<<WHY NOTTT??? only in a constructor
        {
            if(this.Balance - amountToWithdraw <= 0 && this.Balance - amountToWithdraw >= -90) // why no this? why not pointing at object?
            {
                base.Withdraw(amountToWithdraw + 10); //why call base and not create your ownmethod?

                return this.Balance;
            }
            else if(Balance - amountToWithdraw >= 0)
            {
                base.Withdraw(amountToWithdraw);
                return Balance;
            }
            else
            {
                return Balance;
            }
        }
        
            
            
            
        
            

        

        
    }
}
