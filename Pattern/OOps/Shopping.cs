using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class Shopping
    {
<<<<<<< HEAD
         string pur_itm;
         int quantity;
         float itm_price;
         float tot_bill;

        public void Accpt_dtl(string pur_itm, int quantity, float itm_price)
        {
            this.pur_itm = pur_itm;
            this.quantity = quantity;
            this.itm_price = itm_price;


            if (this.quantity <= 0)
            {
                Console.WriteLine("Wrong Quantity");
            }
            else
            {
                tot_bill = this.GetBill();

                this.Display();
            }
        }

            public float GetBill()
            {
                return quantity * itm_price;
            }

            public void Display()
            {
                Console.WriteLine("Purchse_Item"+ pur_itm);
                Console.WriteLine("quantity" + quantity);
                Console.WriteLine("itm_price" + itm_price);
                Console.WriteLine("tot_bill" + tot_bill);
                Console.WriteLine(".........Thank you..........");
            }
            static void Main(string[] args)
            {
                Shopping s = new Shopping();
                s.Accpt_dtl("T-shirt", 3, 300.45f);
                //s.Display();
            }
       

=======
        string pur_itm;
        int quantity;
        long itm_price;

        public void Accpt_dtl(string pur_itm,int quantity,long itm_price)
        {
            this.pur_itm = pur_itm;
        }

>>>>>>> 0b5e1c57d7d859a0e38fc826885c0f53ff390293
    }
}
