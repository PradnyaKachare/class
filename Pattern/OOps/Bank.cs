using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class Bank
    {
        int Acc_no;
        string Cust_nm;
        int bal;       

        public void Bank_dtl(int Acc_no, string Cust_nm, int bal)
        {
            this.Acc_no = Acc_no;
            this.Cust_nm = Cust_nm;
            this.bal = bal;                    

        }
        public void BankDtl_Disply()
        {
            Console.WriteLine("Account Number:"+ Acc_no);
             Console.WriteLine("Customer Name:"+ Cust_nm);
            Console.WriteLine("Customer Balance:"+ bal);
        }
        public void Money_Widrwa()
        {
            Console.WriteLine("Enter withdraw Amount ");
            int n = int.Parse(Console.ReadLine());
            if(bal>n)
            {
                Console.WriteLine("Withdraw the amount in current Balance:");
                bal = bal - n;              
                Console.WriteLine("Withdraw Blance:"+ bal);
            }
            else
            Console.WriteLine("Error....");
        }

        public void Deposit_Amount()
        {
            Console.WriteLine("Deposite Amount in Current balance:");
            int d = int.Parse(Console.ReadLine());        
             bal  = bal + d;
            Console.WriteLine("Current Balance:"+ bal);
        }
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.Bank_dtl(1003,"Veda",18000);
            b.BankDtl_Disply();
            b.Money_Widrwa();
            b.Deposit_Amount();


        }
    }
}
