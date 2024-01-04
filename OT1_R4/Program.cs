using System;
using System.Windows.Forms;

namespace OT1_R4
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_menu());

            //Application.Run(new Frm_areas());
            //Application.Run(new Frm_areas_cottages()); //laitoin että itellä aukee suoraan toi ikkuna
            //Application.Run(new Frm_services());
            //Application.Run(new Frm_reservations());
            //Application.Run(new Frm_customers());
            //Application.Run(new sqltest());
           // Application.Run(new Frm_reports());
        }
    }
}
