using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT1_R4
{
    public class Reservation
    {
        public int Varaus_ID { get; set; }
        public int Asiakas_ID { get; set; }
        public int Mokki_ID { get; set; }
        public DateTime Varaus_pvm { get; set; }
        public DateTime Vahvistus_pvm { get; set; }
        public DateTime Varauksen_alku_pvm  { get; set; }
        public DateTime Varauksen_loppu_pvm   { get; set; }


    }
}
