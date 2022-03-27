using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // Create instance of clsCustomer
        clsCustomer customer = new clsCustomer();
        // sets DateAdded to DateTime
        customer.DateAdded = new DateTime();
        // sets id to 1
        customer.id = 1;
        // store customer in session object
        Session["customer"] = customer;
        // navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

}