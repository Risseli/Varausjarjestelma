using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OT1_R4
{
    internal class Post
    {
        public String Postn { get; set; }
        public String PostPlace { get; set; }


        public String FullPost
        {
            get { return Postn + " " + PostPlace; }
        }

    }
}
