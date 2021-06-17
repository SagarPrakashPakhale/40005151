using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_BL
{
    public abstract class BankAccount
    {
        //Variable Declaration
        private int accountNumber;
        private DateTime accountOpenDate;
        private double creditAmount;
        //Association
        private List<Name> accountHolderName = new List<Name>();
        private  List<Transaction> listOfTransaction= new List<Transaction>();
        private double balanceAmount;



        //Properties
        public double CreditAmount
        {
            get
            {
                return creditAmount;
            }
            set
            {
                creditAmount = value;
            }
        }
        public int AccountNumber {

            get
            {
                return accountNumber;
            }

            set
            {
                accountNumber = value;
            }
        
        }
        public List<Name> AccountHolderName
        {
            get
            {
                return accountHolderName;
            }

            set
            {
                accountHolderName = value;
            }
        }
        public DateTime AccountOpenDate
        {
            get
            {
                return accountOpenDate;
            }

            set
            {
                accountOpenDate = value;
            }
        }
        public double BalanceAmount
        {
            get
            {
                return balanceAmount;
            }

            set
            {
                balanceAmount = value;
            }
        }
        public List<Transaction> ListOfTransaction
        {
            get
            {
                return listOfTransaction;
            }

            set
            {
                listOfTransaction = value;
            }
        }


        //Abstract method declaration
        public abstract double Debit();
       
        



        //Concrete Method Defination
        public double CalculateBalance(ref double bal)
        {
            return BalanceAmount;
        }

        public virtual double Credit()
        {
            return BalanceAmount= BalanceAmount + creditAmount;
        }

    }
}
