using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_BL
{
   public class Transaction
    {
        public int transacID { get; set; }
        public string accountType { get; set; }
        public string action {get; set; }
        public double ammount { get; set; }
        public DateTime time { get; set; }

        /*public Transaction(int transacID, string accountType, string action, double ammount, DateTime time)
        {
             this.transacID= transacID;
            this.accountType = accountType;
            this.action = action;
            this.ammount = ammount;
            this.time = time;
        }*/
    }
}
