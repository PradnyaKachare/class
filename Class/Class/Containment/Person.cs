using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Containment
{

    class Address
    {
        public int pincode;
        public string city;

        public Address(int pincode, string city)
        {
            this.pincode = pincode;
            this.city = city;
        }

        public void ShowAddress()
        {
            Console.WriteLine("" + pincode + "" + city);
        }
    }

    class Person
    {
        public int id;
        public string name;
        Address adr;

        Person(int id, string name, Address adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;


        }
        public void DisplayEmploy()
        {
            Console.WriteLine(id + "" + name);
        }
        static void Main(string[] args)
        {
            /*Address a = new Address(101,"Computer");
            Person p = new Person(1,"veda",980000,a);
            p.DisplayEmploy();*/

            Person per = new Person(105, "Shaurya", new Address(413108, "pune"));
            per.DisplayEmploy();
        }
    }                                                              
}
