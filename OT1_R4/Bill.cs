using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT1_R4
{
    public class Bill
    {
        public int BillID { get; set; }
        public int ReservationID { get; set; }
        public double Amount { get; set; }
        public double Alv { get; set; }
        public bool Paid { get; set; }
        public int CustomerID { get; set; }
        public string CustomerEmail { get; set; }
    }
}
