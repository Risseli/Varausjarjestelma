using System;

namespace OT1_R4
{
    internal class Customer
    {
        public int ID { get; set; }
        public String PostNum { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
        public String Number { get; set; }


        public String FullName
        {
            get { return Name + " " + LastName; }
        }

    }
}
