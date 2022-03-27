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




        //new instance of clsOrder

        clsOrder AnOrder = new clsOrder();

        //capture

        string orderID = txtOrderID.Text;
        Boolean isDelivered = cbIsDelivered.Checked;
        string orderNo = txtOrderNo.Text;
        string CustomerID = txtCustomerID.Text;
        string DatePurchased = txtDatePurchased.Text;
        string TotalPrice = lblTotalPriceOutput.Text;
        string error = "";

        error = AnOrder.Valid(orderNo, CustomerID, DatePurchased);

        if (error == "")
        {
            AnOrder.orderID = Convert.ToInt32(orderID);
            AnOrder.isDelivered = isDelivered;
            AnOrder.orderNo = orderNo;
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.DatePurchased = Convert.ToDateTime(DatePurchased);
            Session["AnOrder"] = AnOrder;
            Response.Write("OrderViewer.aspx");
        }
        else
        {
            lblError.Text = error;
        }


        

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 orderID;
        Boolean Found = false;
        orderID = Convert.ToInt32(txtOrderID.Text);
        Found = AnOrder.Find(orderID);
        if (Found == true)
        {
            txtOrderNo.Text = AnOrder.orderNo;
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtDatePurchased.Text = AnOrder.DatePurchased.ToString();
            lblTotalPrice.Text = AnOrder.TotalPrice.ToString();
        }
    }
}