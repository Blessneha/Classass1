using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1
{
     class Accounts
    {
       public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public int Amount { get; set; }
        
      
        public string accounttype { get; set; }
        public static int balance = 0;
        private string transaction;
        public Accounts(int amount,  string atransactiontype)
        {
            
            Amount = amount;
       
            Transactiontype = atransactiontype;
        }


        public string Transactiontype
        {
            get
            {
                return transaction;
            }

            set
            {
                if(value=="D")
                {   
                    transaction = "D";
                    credit();
                }
                else if(value=="W")
                {
                    transaction = "W";
                    debit();
                }
                else
                {   
                    Console.WriteLine("Invalid");
                }
            }
        }
        public void accept(int accountNumber, string customerName,string acctype)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            accounttype=acctype;
        }


        public void credit()
        {
            if (Amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Amount), "Amount must be positive");
            }
            balance += Amount;
        }
        public void debit()
        {
            if (Amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Amount), "Amount of withdrawal must be positive");
            }
            if (balance - Amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            balance -= Amount;

        }
        public void show()
        {
            Console.WriteLine("Customer name:" + CustomerName);
            Console.WriteLine("the account number :" +AccountNumber+"\naccount type:"+accounttype);
            Console.WriteLine("Balance amount is:"+balance);
            
        }

        

    }
}
