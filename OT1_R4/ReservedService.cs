using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT1_R4
{
    internal class ReservedService
    {
        public int Service_ID { get; set; }
        public int Area_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Alv { get; set; }
        public int Count { get; set; }
    }
}
