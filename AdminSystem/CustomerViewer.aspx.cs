using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer customer = new clsCustomer();
        // gets data from session object
        customer = (clsCustomer)Session["customer"];
        // Display customer id for this entry
        Response.Write(customer.dateAdded + "\n");
        Response.Write(customer.id + "\n");
        Response.Write(customer.name + "\n");
        Response.Write(customer.email + "\n");
        Response.Write(customer.passwrd+ "\n");
        Response.Write(customer.exist+ "\n");

    }
}