using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank_BL
{
     public class CheckingAccount : BankAccount    
    {
        //Variable declaration 
        public double transactionChargeCheckingCheck { get; set; }
        public double creditAmountcheck { get; set; }
        public double debitedcheck { get; set; }


        public override double Credit( )
        {
            return BalanceAmount=BalanceAmount + creditAmountcheck;
        }

        public override double Debit()
        {
            BalanceAmount = BalanceAmount - debitedcheck;
            transactionChargeCheckingCheck = debitedcheck * 2.5 / 100;
            return BalanceAmount = BalanceAmount - transactionChargeCheckingCheck;
            
           
        }

       }
}
