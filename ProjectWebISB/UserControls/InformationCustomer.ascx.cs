using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectWebISB.UserControls
{
    public partial class InformationCustomer : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string Name
        {
            get { return txtName.Text; }
        }
         public string Email
        {
            get { return txtEmail.Text; }
        }
        public string IcPassport
        {
            get { return txtIcPassport.Text; }
        }

    }
}