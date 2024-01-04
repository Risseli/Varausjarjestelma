using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace OT1_R4
{
    public partial class Frm_billing : Form
    {

        BindingSource billsBS = new BindingSource();
        BindingSource reservationsBS = new BindingSource();

        string billSearchString = "";
        string resSearchString = "";

        int selectedBillID = -1;
        int selectedReservationID = -1;

        public Frm_billing()
        {
            InitializeComponent();

            LoadBills();

            LoadReservations();
        }

        //Loads bills into datagridview
        private void LoadBills()
        {
            //Loads all the cottages into the datagridview from the database
            BillsDAO billsDAO = new BillsDAO();

            billsBS.DataSource = billsDAO.GetAllBills();

            dgv_bills.DataSource = billsBS;
        }

        //Loads reservations into datagridview
        private void LoadReservations()
        {
            ReservationsDAO reservationsDAO = new ReservationsDAO();

            reservationsBS.DataSource = reservationsDAO.getReservations();
            dgv_reservations.DataSource = reservationsBS;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti sulkea ohjelman?", "Sulje ohjelma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Stores the id of the selected bill
        private void dgv_bills_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            //get the row nubmer clicked

            int rowSelected = dgv.CurrentRow != null ? dgv.CurrentRow.Index : -1;

            //MessageBox.Show("Painoit riviä " + rowSelected);

            //Taking the ID of the selected bill, something has to be selected
            if (rowSelected >= 0)
            {
                selectedBillID = (int)dgv.Rows[rowSelected].Cells[0].Value;
            }
            else
            {
                selectedBillID = -1;
            }
        }

        //Stores the id of the selected reservation
        private void dgv_reservations_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            //get the row nubmer clicked
            int rowSelected = dgv.CurrentRow != null ? dgv.CurrentRow.Index : -1;

            //MessageBox.Show("Painoit riviä " + rowClicked);

            //Taking the ID of the selected reservation, something has to be selected
            if (rowSelected >= 0)
            {
                selectedReservationID = (int)dgv.Rows[rowSelected].Cells[0].Value;
            }
            else
            {
                selectedReservationID = -1;
                lbl_title.Text = selectedReservationID.ToString();
            }
        }

        //Deletes a selected bill from the database
        private void btn_delete_bill_Click(object sender, EventArgs e)
        {
            if (selectedBillID == -1)
            {
                toolTip1.ToolTipTitle = "Laskua ei ole valittu!";
                toolTip1.Show("Valitse lasku listasta, jonka haluat poistaa!", btn_delete_bill, 0, btn_delete_bill.Height, 5000);
            }
            else
            {
                if (MessageBox.Show("Haluatko varmasti poistaa laskun " + selectedBillID.ToString() + "?", "Varoitus!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    BillsDAO billsDAO = new BillsDAO();
                    int removedRows = billsDAO.DeleteBill(selectedBillID);

                    if (removedRows > 0)
                    {
                        //ClearInputs();
                        selectedBillID = -1;
                        LoadBills();
                        //MessageBox.Show("Poisto onnistui.");
                    }
                    else
                    {
                        MessageBox.Show("Poisto epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Changes a bills paid status to paid or not paid
        private void btn_edit_bill_Click(object sender, EventArgs e)
        {
            //Checks that a bill is selected
            if (selectedBillID == -1)
            {
                toolTip1.ToolTipTitle = "Laskua ei ole valittu!";
                toolTip1.Show("Valitse lasku listasta, jonka maksutilan haluat muuttaa!", btn_edit_bill, 0, btn_edit_bill.Height, 5000);
                return;
            }

            int newStatus = 0;

            //If the bill is not paid, make the newStatus to be 1 (paid)
            if (!(bool)dgv_bills.Rows[dgv_bills.CurrentRow.Index].Cells[4].Value)
            {
                newStatus = 1;
            }
            
            BillsDAO billsDAO = new BillsDAO();

            int affectedRows = billsDAO.ChangePaidStatus(selectedBillID, newStatus);

            if (affectedRows > 0)
            {
                //ClearInputs();
                selectedBillID = -1;
                LoadBills();
                //MessageBox.Show("Muokkaus onnistui.");
            }
            else
            {
                MessageBox.Show("Muokkaus epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Creates and adds a new bill to the database
        private void btn_add_bill_Click(object sender, EventArgs e)
        {
            if (selectedReservationID == -1)
            {
                toolTip1.ToolTipTitle = "Varausta ei ole valittu!";
                toolTip1.Show("Valitse varaus listasta, josta haluat luoda laskun!", btn_add_bill, 0, btn_add_bill.Height, 5000);
                return;
            }

            //Calculates the total price for the reservation
            double totalPrice = CalculateTotalPrice(selectedReservationID);
            double alv = 23;

            BillsDAO billsDAO = new BillsDAO();

            int newRows = billsDAO.AddBill(selectedReservationID, totalPrice, alv);

            if (newRows > 0)
            {
                //ClearInputs();
                //selectedReservationID = -1;
                LoadBills();
                MessageBox.Show("Luonti onnistui.");
            }
            else
            {
                MessageBox.Show("Luonti epäonnistui!", "Virhe!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Calculates the total price for the reservation
        private double CalculateTotalPrice(int reservID)
        {
            //Calculates the total price from the cottage
            ReservationsDAO resDAO = new ReservationsDAO();
            
            double cottagePrice = resDAO.GetCottagePrice(reservID); //Price per day

            DateTime[] dates = resDAO.GetStartAndEndDate(reservID);

            double days = (dates[1].Date - dates[0].Date).TotalDays; //How many days

            double totalPriceCottage = cottagePrice * days; //In total


            //Calculates the total price from services
            List<ReservedService> reservedServices = resDAO.GetServices(reservID); //Gets the services

            double totalPriceServices = 0;
            foreach (ReservedService rs in reservedServices) //Adds up the price of the services
            {
                totalPriceServices += rs.Price * rs.Count;
            }


            double totalPrice = totalPriceCottage + totalPriceServices; //Sums the two totals together

            return totalPrice;
        }

        //Searches the reservations based on customers email
        private void btn_search_reservations_Click(object sender, EventArgs e)
        {
            using (Frm_search_reservations frm_search = new Frm_search_reservations(resSearchString))
            {
                if (frm_search.ShowDialog() == DialogResult.OK)
                {
                    reservationsBS.DataSource = frm_search.ReturnList;

                    dgv_reservations.DataSource = null;

                    dgv_reservations.DataSource = reservationsBS;
                }

                resSearchString = frm_search.LastSearch;
            }
        }

        //Searches the bills based on customers email
        private void btn_search_bill_Click(object sender, EventArgs e)
        {
            using (Frm_search_bills frm_search = new Frm_search_bills(billSearchString))
            {
                if (frm_search.ShowDialog() == DialogResult.OK)
                {
                    billsBS.DataSource = frm_search.ReturnList;

                    dgv_bills.DataSource = null;

                    dgv_bills.DataSource = billsBS;
                }

                billSearchString = frm_search.LastSearch;
            }
        }


        //Writes an email bill
        private void btn_email_bill_Click(object sender, EventArgs e)
        {
            if (selectedBillID == -1)
            {
                toolTip1.ToolTipTitle = "Laskua ei ole valittu!";
                toolTip1.Show("Valitse lasku listasta, josta haluat luoda sähköpostilaskun!", btn_email_bill, 0, btn_email_bill.Height, 5000);
                return;
            }

            sfd_bill.FileName = "email_bill_" + selectedBillID;
            if (sfd_bill.ShowDialog() == DialogResult.OK)
            {
                ReservationsDAO resDAO = new ReservationsDAO();

                int reservationID = (int)dgv_bills.Rows[dgv_bills.CurrentRow.Index].Cells[1].Value;

                
                double cottagePrice = resDAO.GetCottagePrice(reservationID); //Price per day

                DateTime[] dates = resDAO.GetStartAndEndDate(reservationID);

                double days = (dates[1].Date - dates[0].Date).TotalDays; //How many days


                //Calculates the total price from services
                List<ReservedService> reservedServices = resDAO.GetServices(reservationID); //Gets the services

                double totalPriceServices = 0;
                foreach (ReservedService rs in reservedServices) //Adds up the price of the services
                {
                    totalPriceServices += rs.Price * rs.Count;
                }

                //using (StreamWriter sw = new StreamWriter(sfd_bill.FileName))
                //{
                //    sw.WriteLine("Tämä lasku lähetetään sähköpostitse osoitteeseen: " + dgv_bills.Rows[dgv_bills.CurrentRow.Index].Cells[6].Value);
                //    sw.WriteLine("\n");
                //    sw.WriteLine("Maksa lasku tilille \t\t\tFI39 123456789 123456789");
                //    sw.WriteLine("Viite numero on \t\t\t123456789");
                //    sw.WriteLine("Maksettava summa on: \t\t\t" + CalculateTotalPrice(reservationID) + "€");

                //    sw.WriteLine("\nMajoittuitte mökkiimme " + dates[0].ToShortDateString() + " - " + dates[1].ToShortDateString());

                //    sw.WriteLine("\nHintaerittely:");
                //    sw.WriteLine("Mökin hinta on " + cottagePrice + "€ * " + days + "(päivää) = \t" + cottagePrice * days + "€");
                //    sw.WriteLine("Lisäpalveluiden hinta yhteensä = \t" + totalPriceServices + "€");

                //    sw.WriteLine("\nLisäpalvelut eriteltynä:");
                //    foreach (ReservedService rs in reservedServices) //Adds up the price of the services
                //    {
                //        sw.WriteLine(rs.Name + ", " + rs.Price + "€ * " + rs.Count + " = " + rs.Price * rs.Count + "€");
                //    }
                //}

                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(sfd_bill.FileName, FileMode.Create));
                doc.Open();
                doc.Add(new Paragraph("Tämä lasku lähetetään sähköpostitse osoitteeseen: " + dgv_bills.Rows[dgv_bills.CurrentRow.Index].Cells[6].Value));
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("Maksa lasku tilille \t\t\tFI39 123456789 123456789"));
                doc.Add(new Paragraph("Viitenumero on \t\t\t123456789"));
                doc.Add(new Paragraph("Maksettava summa on: \t\t\t" + CalculateTotalPrice(reservationID) + "€"));

                doc.Add(new Paragraph("\nMajoittuitte mökkiimme " + dates[0].ToShortDateString() + " - " + dates[1].ToShortDateString()));

                doc.Add(new Paragraph("\nHintaerittely:"));
                doc.Add(new Paragraph("Mökin hinta on " + cottagePrice + "€ * " + days + "(päivää) = \t" + cottagePrice * days + "€"));
                doc.Add(new Paragraph("Lisäpalveluiden hinta yhteensä = \t" + totalPriceServices + "€"));

                doc.Add(new Paragraph("\nLisäpalvelut eriteltynä:"));
                foreach (ReservedService rs in reservedServices) //Adds up the price of the services
                {
                    doc.Add(new Paragraph(rs.Name + ", " + rs.Price + "€ * " + rs.Count + " = " + rs.Price * rs.Count + "€"));
                }
                doc.Close();
            }
        }

        //Writes a paper bill
        private void btn_paper_bill_Click(object sender, EventArgs e)
        {
            if (selectedBillID == -1)
            {
                toolTip1.ToolTipTitle = "Laskua ei ole valittu!";
                toolTip1.Show("Valitse lasku listasta, josta haluat luoda paperilaskun!", btn_paper_bill, 0, btn_paper_bill.Height, 5000);
                return;
            }

            sfd_bill.FileName = "paper_bill_" + selectedBillID;
            if (sfd_bill.ShowDialog() == DialogResult.OK)
            {
                ReservationsDAO resDAO = new ReservationsDAO();

                int reservationID = (int)dgv_bills.Rows[dgv_bills.CurrentRow.Index].Cells[1].Value;

                string[] address = resDAO.GetCustomerAddress(reservationID);

                double cottagePrice = resDAO.GetCottagePrice(reservationID); //Price per day

                DateTime[] dates = resDAO.GetStartAndEndDate(reservationID);

                double days = (dates[1].Date - dates[0].Date).TotalDays; //How many days


                //Calculates the total price from services
                List<ReservedService> reservedServices = resDAO.GetServices(reservationID); //Gets the services

                double totalPriceServices = 0;
                foreach (ReservedService rs in reservedServices) //Adds up the price of the services
                {
                    totalPriceServices += rs.Price * rs.Count;
                }

                //using (StreamWriter sw = new StreamWriter(sfd_bill.FileName))
                //{
                //    sw.WriteLine("Tämä lasku lähetetään osoitteeseen: " + address[0] + ", " + address[1] + " " + address[2]);
                //    sw.WriteLine("\n");
                //    sw.WriteLine("Maksa lasku tilille \t\t\tFI39 123456789 123456789");
                //    sw.WriteLine("Viite numero on \t\t\t123456789");
                //    sw.WriteLine("Maksettava summa on: \t\t\t" + CalculateTotalPrice(reservationID) + "€");

                //    sw.WriteLine("\nMajoittuitte mökkiimme " + dates[0].ToShortDateString() + " - " + dates[1].ToShortDateString());

                //    sw.WriteLine("\nHintaerittely:");
                //    sw.WriteLine("Mökin hinta on " + cottagePrice + "€ * " + days + "(päivää) = \t" + cottagePrice * days + "€");
                //    sw.WriteLine("Lisäpalveluiden hinta yhteensä = \t" + totalPriceServices + "€");

                //    sw.WriteLine("\nLisäpalvelut eriteltynä:");
                //    foreach (ReservedService rs in reservedServices) //Adds up the price of the services
                //    {
                //        sw.WriteLine(rs.Name + ", " + rs.Price + "€ * " + rs.Count + " = " + rs.Price * rs.Count + "€");
                //    }
                //}


                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(sfd_bill.FileName, FileMode.Create));
                doc.Open();
                doc.Add(new Paragraph("Tämä lasku lähetetään osoitteeseen: " + address[0] + ", " + address[1] + " " + address[2]));
                doc.Add(new Paragraph("\n"));
                doc.Add(new Paragraph("Maksa lasku tilille \t\t\tFI39 123456789 123456789"));
                doc.Add(new Paragraph("Viitenumero on \t\t\t123456789"));
                doc.Add(new Paragraph("Maksettava summa on: \t\t\t" + CalculateTotalPrice(reservationID) + "€"));

                doc.Add(new Paragraph("\nMajoittuitte mökkiimme " + dates[0].ToShortDateString() + " - " + dates[1].ToShortDateString()));

                doc.Add(new Paragraph("\nHintaerittely:"));
                doc.Add(new Paragraph("Mökin hinta on " + cottagePrice + "€ * " + days + "(päivää) = \t" + cottagePrice * days + "€"));
                doc.Add(new Paragraph("Lisäpalveluiden hinta yhteensä = \t" + totalPriceServices + "€"));

                doc.Add(new Paragraph("\nLisäpalvelut eriteltynä:"));
                foreach (ReservedService rs in reservedServices) //Adds up the price of the services
                {
                    doc.Add(new Paragraph(rs.Name + ", " + rs.Price + "€ * " + rs.Count + " = " + rs.Price * rs.Count + "€"));
                }
                doc.Close();
            }
        }

        
    }
}
