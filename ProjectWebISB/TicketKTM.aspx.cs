using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectWebISB
{
    public partial class TicketKTM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            DateTime dateTimeNow = DateTime.Now;
            lblDateBuy.Text = dateTimeNow.Date.ToString("dd-MM-yyyy");
            long invoiceNo = dateTimeNow.Ticks - 637523990000000000;
            lblInvoiceNo.Text = invoiceNo.ToString("X");
            lblName.Text = InformationCustomer.Name;
            lblICpassport.Text = InformationCustomer.IcPassport;
            lblEmail.Text = InformationCustomer.Email;
            lblFrom.Text = DestinationLocation.FirstLocation;
            lblTo.Text = DestinationLocation.SecondLocation;
            lblDate.Text = DestinationLocation.DateGoing;

            lblForPerson.Text = DestinationLocation.HowManyPerson;
            lbl1or2way.Text = DestinationLocation.OneorTwoway;
            lblTotalPrice.Text = DestinationLocation.TotalPrice;
        }
    }
}