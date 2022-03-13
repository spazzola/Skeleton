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
        clsStock Stock = new clsStock();
        Stock = (clsStock)Session["Stock"];
        Response.Write(Stock.ItemDescription);
        Response.Write(Stock.ItemAmount);
        Response.Write(Stock.ItemAvailable);
        Response.Write(Stock.ItemPrice);
        Response.Write(Stock.ItemShipment);
    }
}