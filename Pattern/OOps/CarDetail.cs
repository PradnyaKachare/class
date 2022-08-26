using System;

namespace Pattern.OOps
{
    class CarDetail
    {
        string c_nm;
        string model_no;

        public CarDetail() //: this("Swift", "a2")
        {
            Console.WriteLine("Default Car");
            
        }

        public CarDetail(string c_nm, string model_no) :this()
        {
            this.c_nm = c_nm;
            this.model_no = model_no;
            this.Show();

        }
        public void Show()
        {
            Console.WriteLine(c_nm + " " + model_no);
        }

    }
    class ThisUse3
    {
        static void Main(string[] args)
        {
            CarDetail c = new CarDetail("Audi", "Q9");

            //CarDetail c2 = new CarDetail();
            //c2.Car("Audi", "Q9");
            //  c2.Show();

        }
    }
}
