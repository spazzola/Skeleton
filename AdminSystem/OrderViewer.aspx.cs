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
        //new instance of clsOrder

        clsOrder AnOrder = new clsOrder();

        //retrieve data from session object

        AnOrder = (clsOrder)Session["AnOrder"];

        //display orderNo for entry

        Response.Write(AnOrder.orderID);
    }
}