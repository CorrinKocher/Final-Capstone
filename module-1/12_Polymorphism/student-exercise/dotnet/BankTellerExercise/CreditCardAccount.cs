using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CreditCardAccount : IAccountable
    {
        public CreditCardAccount (string accountHolderName, string accountNumber)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
            
        }

        public int Balance { get; set; } 
        
        public string AccountHolderName { get; }

        public string AccountNumber { get; }

        public int Debt
        {
            get
            {
               return Balance * -1;
                
            }
        }
       
        public int Pay(int amountToPay)
        {
            return Balance += amountToPay;
            
        }
        public int Charge(int amountToCharge)
        {
            return Balance -= amountToCharge;
        }
    }
}
