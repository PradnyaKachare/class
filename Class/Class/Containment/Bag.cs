using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Containment
{
    class Pen
    {
        string p_nm;
        string p_clr;
        float length;
        string typ;

        public string P_nm
        {
            get { return p_nm; }
            set { p_nm = value; }
            
        }
        public string P_clr
        {
            get { return p_clr; }
            set { p_clr = value; }
        }
        public float Length
        {
            get { return length; }
            set { length = value; }
        }
        public string Typ
        {

            get { return typ; }
            set { typ = value; }
        }

    }
    class Bag
    {
        string brandnm;
        int price;
        string color;
        Pen pn;
        public string Brandnm
        {
            get { return brandnm; }
            set { brandnm = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Color
        {

            get { return color; }
            set { color = value; }

        }
        public Pen Pn
        {
            get { return pn; }
            set { pn = value; }
        }
    }
    class Compas
    {
        static void Main(string[] args)
        {
            Bag c = new Bag();

            c.Brandnm = "ABC";
            c.Price = 20;
            c.Color = "Pink";

            Pen p1 = new Pen();
            c.Pn = p1;

            c.Pn.P_nm = "Ink Pen";
            c.Pn.P_clr = "Black";
            c.Pn.Length = 6.7f;
            c.Pn.Typ = "Ink";

           Console.WriteLine(c.Brandnm +""+c.Price+""+c.Color+""+c.Pn.P_nm +""+c.Pn.P_clr+"" +c.Pn.Length+""+c.Pn.Typ);

        }
    }
}
