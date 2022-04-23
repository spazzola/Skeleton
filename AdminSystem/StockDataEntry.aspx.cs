using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 stockNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        stockNo = Convert.ToInt32(Session["ItemId"]);
        if (IsPostBack == false)
        {
            if (stockNo != -1)
            {
                DisplayStock();
            }
        }
    }

    private void DisplayStock()
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(stockNo);
        txtID.Text = StockBook.ThisStock.ItemID.ToString();
        txtItemDesc.Text = StockBook.ThisStock.ItemDescription;
        txtItemAmount.Text = StockBook.ThisStock.ItemAmount.ToString();
        txtItemPrice.Text = StockBook.ThisStock.ItemPrice.ToString();
        txtNextShipment.Text = StockBook.ThisStock.ItemShipment.ToString();
        chkAvailable.Checked = StockBook.ThisStock.ItemAvailable;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsDataConnection DB = new clsDataConnection();
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
            clsStockCollection AllStock = new clsStockCollection();
            AllStock.ThisStock = Stock;

            if (stockNo == -1)
            {
                AllStock.Add();
            } else
            {
                AllStock.Update();
            }
            Response.Redirect("StockList.aspx");
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