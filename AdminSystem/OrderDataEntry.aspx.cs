using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["orderID"]);
        
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();

        Orders.ThisOrder.Find(OrderID);

        txtOrderID.Text = Orders.ThisOrder.orderID.ToString();
        cbIsDelivered.Checked = Orders.ThisOrder.isDelivered;
        txtOrderNo.Text = Orders.ThisOrder.orderNo;
        txtCustomerID.Text = Orders.ThisOrder.CustomerID.ToString();
        txtDatePurchased.Text = Orders.ThisOrder.DatePurchased.ToString();
        lblTotalPrice.Text = Orders.ThisOrder.TotalPrice.ToString();
         
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {




        //new instance of clsOrder

        clsOrder AnOrder = new clsOrder();

        //capture


        Boolean isDelivered = cbIsDelivered.Checked;
        string orderID = txtOrderID.Text;
        string orderNo = txtOrderNo.Text;
        string CustomerID = txtCustomerID.Text;
        string DatePurchased = "25/03/2022 00:00";
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

            





            clsOrderCollection orderList = new clsOrderCollection();

            if (OrderID == -1)
            {

                orderList.ThisOrder = AnOrder;

                orderList.Add();


            }
            else
            {
                orderList.ThisOrder.Find(OrderID);

                orderList.ThisOrder = AnOrder;

                orderList.Update();
            }

            Response.Redirect("OrderList.aspx");



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

        protected void txtDatePurchased_TextChanged(object sender, EventArgs e)
         {

           }
}