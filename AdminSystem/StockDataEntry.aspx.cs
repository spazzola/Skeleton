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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock Stock = new clsStock();
        Stock.ItemAmount = Int16.Parse(txtItemAmount.Text);
        Stock.ItemAvailable = chkAvailable.Checked;
        Stock.ItemPrice = float.Parse(txtItemPrice.Text);
        Stock.ItemShipment = DateTime.Parse(txtNextShipment.Text);
        Stock.ItemDescription = txtItemDesc.Text;
        Session["Stock"] = Stock;
        Response.Redirect("StockViewer.aspx");
    }
}