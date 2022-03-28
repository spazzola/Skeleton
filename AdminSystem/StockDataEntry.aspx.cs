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
        string ID = txtID.Text;
        string Desc = txtItemDesc.Text;
        string Price = txtItemPrice.Text;
        string Amount = txtItemAmount.Text;
        string Available = chkAvailable.Checked.ToString();
        string Shipment = txtNextShipment.Text;
        string Error = "";
        Error = Stock.Valid(Desc, Price, Amount, Available, Shipment);
        
        if (Error == "")
        {
            Stock.ItemID = Convert.ToInt32(txtID.Text);
            Stock.ItemAmount = Int16.Parse(txtItemAmount.Text);
            Stock.ItemAvailable = chkAvailable.Checked;
            Stock.ItemPrice = float.Parse(txtItemPrice.Text);
            Stock.ItemShipment = DateTime.Parse(txtNextShipment.Text);
            Stock.ItemDescription = txtItemDesc.Text;
            Session["Stock"] = Stock;
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock Stock = new clsStock();
        Int32 ID;
        Boolean Found = false;
        ID = Convert.ToInt32(txtID.Text);
        Found = Stock.Find(ID);
        if (Found == true)
        {
            txtItemDesc.Text = Stock.ItemDescription;
            txtItemPrice.Text = Convert.ToString(Stock.ItemPrice);
            txtItemAmount.Text = Convert.ToString(Stock.ItemAmount);
            chkAvailable.Checked = Stock.ItemAvailable;
            txtNextShipment.Text = Convert.ToString(Stock.ItemShipment);
        }
    }
}