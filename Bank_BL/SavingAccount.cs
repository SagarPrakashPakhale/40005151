using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_BL
{
   public class SavingAccount:BankAccount
    {
        //Variable declaration 
        public double transactionChargeSaving { get; set; }
        public double creditAmount { get; set; }
        public double debitAmount { get; set; }

        //override Methods
        public override double Credit()
        {
            return  BalanceAmount = BalanceAmount+creditAmount;
        }

        public override double Debit()
        {

            transactionChargeSaving = debitAmount * 1 / 100;
           
                BalanceAmount = BalanceAmount - debitAmount;
                return BalanceAmount = BalanceAmount - transactionChargeSaving;
            
           

             
        }

        /*public override double CalculateBalance()
        {
            return BalanceAmount;
        }*/
    }
}
