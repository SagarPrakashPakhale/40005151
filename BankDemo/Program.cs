using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_BL;
namespace BankDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sAccObj = new SavingAccount();//saving account 
            CheckingAccount cAccObj = new CheckingAccount();//checking account
            double checkbalance = 5000;
            Name nav = new Name();
           
            int trID = 0;

           
           
            DateTime session = System.DateTime.Now.AddMinutes(5);
            // Console.WriteLine(session);
            int choice = 0;
            do
            {

                nav.firstName = "Sagar";
                nav.lastName = "Pakhale";
                sAccObj.AccountHolderName.Add(nav);
                sAccObj.AccountOpenDate = System.DateTime.Now.AddDays(-234);
               

                double balance = 10000;
                sAccObj.BalanceAmount = balance;
                sAccObj.AccountNumber = 100021;
               
                Console.WriteLine("\n****************WELCOME *************\n*****************MY BANK************* \n1.Saving Account\n2.Cheking Account\n3.Exit\nENTER YOUR CHOICE PLEASE....");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please Enter Number:");
                    choice = Convert.ToInt32(Console.ReadLine());
                }

                switch (choice)
                {
                    case 1:
                       
                        int choice1 = 0;
                        Console.WriteLine("\n*************WELCOME IN SAVING ACCOUNT****************");
                        foreach (var name in sAccObj.AccountHolderName)
                        {
                            Console.WriteLine(name.firstName + " " + name.lastName);
                        }
                        Console.WriteLine("ACCOUNT No:" + sAccObj.AccountNumber + " " + "ACCOUNT OPENING DATE: " + sAccObj.AccountOpenDate);
                        do
                        {
                            
                            Console.WriteLine("\n1.CalculateBalance\n2.Credit\n3.Debit\n4.Last Five Transactions\n5.Exit");
                            try
                            {
                                choice1 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch(Exception)
                            {
                                Console.WriteLine("Please Enter Number");
                                choice1 = Convert.ToInt32(Console.ReadLine());

                            }
                            if(choice1==2 || choice1==3)
                                trID++;


                            switch (choice1)
                            {
                               
                                case 1:
                                   double balance1= sAccObj.CalculateBalance(ref balance);
                                    Console.WriteLine("Saving Account Balance is:"+balance1);
                                    break;
                                case 2:
                                    Console.WriteLine("PLEASE ENTER AMOUNT");
                                    try
                                    {
                                        double creditAmount = Convert.ToInt32(Console.ReadLine());
                                        sAccObj.CreditAmount = creditAmount;
                                    }
                                    catch(Exception)
                                    {
                                        Console.WriteLine("Please Enter Valid amount");
                                        double creditAmount = Convert.ToInt32(Console.ReadLine());
                                        sAccObj.CreditAmount = creditAmount;
                                    }


                                    Transaction tran3 = new Transaction();
                                    tran3.accountType = "SavingAccount";
                                    tran3.action = nameof(sAccObj.Credit);
                                    tran3.ammount = sAccObj.CreditAmount;
                                    tran3.time = System.DateTime.Now;
                                    tran3.transacID = trID;
                                    sAccObj.Credit();
                                    sAccObj.ListOfTransaction.Add(tran3);
                                    Console.WriteLine("Successfully Credited.......");
                                    break;
                                case 3:
                                    Console.WriteLine("PLEASE ENTER AMOUNT");
                                    try
                                    {
                                        double debitAmount = Convert.ToInt32(Console.ReadLine());
                                        sAccObj.debitAmount = debitAmount;
                                    }
                                    catch(Exception)
                                    {
                                        Console.WriteLine("Please Enter Valid amount");
                                        double debitAmount = Convert.ToInt32(Console.ReadLine());
                                        sAccObj.debitAmount = debitAmount;
                                    }
                                    Transaction tran1 = new Transaction();
                                    tran1.accountType = "SavingAccount";
                                    tran1.action = nameof(sAccObj.Debit);
                                    tran1.ammount = sAccObj.debitAmount;
                                    tran1.time = System.DateTime.Now;
                                    tran1.transacID = trID;
                                    sAccObj.Debit();
                                    sAccObj.ListOfTransaction.Add(tran1);
                                    Console.WriteLine("Successfully Debited ....");
                                    break;
                                case 4:
                                    if(sAccObj.ListOfTransaction.Count==0)
                                    {
                                        Console.WriteLine("\n***************************\nSorry No Transaction Detail Found.....");
                                    }
                                    else
                                    {
                          
                                        foreach (var s in sAccObj.ListOfTransaction)
                                        {
                                            Console.WriteLine("\n***********************************************************"+"\nTransactio ID:"+s.transacID+"\n "+"Account Type:"+s.accountType + "\n "+"Transaction Type:" + s.action + "\n "+"Transaction Amount:" + s.ammount + "\n "+"Transaction Time:" + s.time);
                                        }
                                    }
                                    break;
                            }
                            
                        } while(choice1!=5);
                        break;
                    case 2:

                        nav.firstName = "Prakash";
                        nav.lastName = "Pakhale";
                        cAccObj.AccountNumber = 10000123;
                        cAccObj.AccountHolderName.Add(nav);
                        cAccObj.AccountOpenDate = System.DateTime.Now.AddDays(-234);
                        Console.WriteLine("\n*************WELCOME IN CHECKING ACCOUNT****************");
                        foreach (var name in cAccObj.AccountHolderName)
                        {
                            Console.WriteLine(name.firstName + " " + name.lastName);
                        }

                        Console.WriteLine("ACCOUNT No:"+cAccObj.AccountNumber + " " + "ACCOUNT Open Date: " + cAccObj.AccountOpenDate);
                        cAccObj.BalanceAmount = checkbalance;
                        int choice2 = 0;
                        Transaction tran = new Transaction();
                        do
                        {
                            
                            Console.WriteLine("\n1.CalculateBalance\n2.Credit\n3.Debit\n4.Last Five Transactions\n5.Exit");
                            try
                            {
                                choice2 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch(Exception)
                            {
                                Console.WriteLine("Please Enter Number");
                                choice2 = Convert.ToInt32(Console.ReadLine());

                            }
                            if (choice2 == 2 || choice2 == 3)
                                trID++;


                            switch (choice2)
                            {

                                case 1:
                                    double balance1 = cAccObj.CalculateBalance(ref balance);
                                    Console.WriteLine("Checking Account Balance is:"+balance1);
                                    break;
                                case 2:
                                    Console.WriteLine("PLEASE ENTER AMOUNT");
                                    try
                                    {
                                        double creditAmount = Convert.ToInt32(Console.ReadLine());
                                        cAccObj.CreditAmount = creditAmount;
                                    }
                                    catch(Exception)
                                    {
                                        Console.WriteLine("Enter valid amount");
                                        double creditAmount = Convert.ToInt32(Console.ReadLine());
                                        cAccObj.CreditAmount = creditAmount;  
                                    }
                                    Transaction tran2 = new Transaction();
                                    tran2.accountType = "CheckingAccount";
                                    tran2.action = nameof(cAccObj.Credit);
                                    tran2.ammount = cAccObj.CreditAmount;
                                    tran2.time = System.DateTime.Now;
                                    tran2.transacID = trID;
                                    cAccObj.Credit();
                                    cAccObj.ListOfTransaction.Add(tran2);
                                    Console.WriteLine("Successfully Credited....");
                                    break;
                                case 3:
                                    Console.WriteLine("PLEASE ENTER AMOUNT");
                                    try
                                    {
                                        double debitAmount = Convert.ToInt32(Console.ReadLine());
                                        cAccObj.debitedcheck = debitAmount;
                                    }
                                    catch(Exception)
                                    {
                                        Console.WriteLine("Please enter valid amount");
                                        double debitAmount = Convert.ToInt32(Console.ReadLine());
                                        cAccObj.debitedcheck = debitAmount;
                                    }


                                    Transaction tran1 = new Transaction();
                                    tran1.accountType = "CheckingAccount";
                                    tran1.action = nameof(sAccObj.Debit);
                                    tran1.ammount = sAccObj.debitAmount;
                                    tran1.time = System.DateTime.Now;
                                    tran1.transacID = trID;
                                    
                                    cAccObj.Debit();
                                    cAccObj.ListOfTransaction.Add(tran1);
                                    Console.WriteLine("Successfully Debited....");
                                    break;
                                case 4:
                                    if (cAccObj.ListOfTransaction.Count == 0)
                                    {
                                        Console.WriteLine("\n*********************************\nSorry No Transaction Detail Found.....");
                                    }
                                    else
                                    {
                                        foreach (var s in cAccObj.ListOfTransaction)
                                        {
                                            
                                            Console.WriteLine("\n********************************************************************************"+"\nTransactio ID:" + s.transacID + "\n " + "Account Type:" + s.accountType + "\n " + "Transaction Type:" + s.action + "\n " + "Transaction Amount:" + s.ammount + "\n " + "Transaction Time:" + s.time);
                                        }
                                    }
                                    break;
                            }

                        } while (choice2 != 5);
                        break;

                }
            } while (System.DateTime.Now!=session && choice!=3);
           

           /*  //Saving Implementation
            SavingAccount sAccObj = new SavingAccount();
            Name nav = new Name();
            sAccObj.AccountNumber = 12456;
            nav.firstName = "Sagar";
            nav.lastName = "Pakhale";

            sAccObj.AccountHolderName.Add(nav);
             sAccObj.AccountOpenDate = System.DateTime.Now;
            foreach(var name in sAccObj.AccountHolderName)
            {
                Console.WriteLine(name.firstName+ " " +name.lastName);
            }
            Console.WriteLine(sAccObj.AccountNumber+ " "  + " " +sAccObj.AccountOpenDate );
            sAccObj.BalanceAmount = 100000;
            sAccObj.creditAmount = 500;
            int i = 100001;
            Transaction tran = new Transaction();
            tran.accountType = "SavingAccount";
            tran.action = nameof(sAccObj.Credit);
            tran.ammount = sAccObj.creditAmount;
            tran.time = System.DateTime.Now;
            tran.transacID = i; 
           sAccObj.ListOfTransaction.Add(tran);
            Console.WriteLine("List of Last five Transaction In Saving Account:");
            foreach (var s in sAccObj.ListOfTransaction)
            {
                Console.WriteLine(s.accountType + " " + s.action + " " + s.ammount + " " + s.time);
            }




            //checking Implementation
            CheckingAccount cAccObj = new CheckingAccount();
            //Name nav = new Name();
            cAccObj.AccountNumber = 11234567;
            nav.firstName = "Sagar1";
            nav.lastName = "Pakhale1";

            cAccObj.AccountHolderName.Add(nav);
            cAccObj.AccountOpenDate = System.DateTime.Now;
            foreach (var name in cAccObj.AccountHolderName)
            {
                Console.WriteLine(name.firstName + " " + name.lastName);
            }
            Console.WriteLine(cAccObj.AccountNumber + " " + " " + cAccObj.AccountOpenDate);
            cAccObj.BalanceAmount = 100000;
            cAccObj.creditAmountcheck = 500;
            int j = 100001;
            //Transaction tran = new Transaction();
            tran.accountType = "SavingAccount";
            tran.action = nameof(cAccObj.Credit);
            tran.ammount = sAccObj.creditAmount;
            tran.time = System.DateTime.Now;
            tran.transacID = i;
            cAccObj.ListOfTransaction.Add(tran);
            Console.WriteLine("List of Last five Transaction In Saving Account:");
            foreach (var s in cAccObj.ListOfTransaction)
            {
                Console.WriteLine(s.accountType + " " + s.action + " " + s.ammount + " " + s.time);
            }*/
        }
    }
}
