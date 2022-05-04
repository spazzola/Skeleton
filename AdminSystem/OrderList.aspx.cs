using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 orderID;
    protected void Page_Load(object sender, EventArgs e)
    {

        orderID = Convert.ToInt32(Session["orderID"]);

        if (IsPostBack == false)
        {
            
                DisplayOrders();
          
            
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();

        

        lstOrderList.DataSource = Orders.orderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "OrderNo";
        lstOrderList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["orderID"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;

        if (lstOrderList.SelectedIndex != -1){
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["orderID"] = OrderID;
            Response.Redirect("OrderDataEntry.aspx");


        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;

        if (lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["orderID"] = OrderID;
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list.";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByOrderNo(txtFilter.Text);
        lstOrderList.DataSource = Orders.orderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "OrderNo";

        lstOrderList.DataBind();


    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByOrderNo("");

        txtFilter.Text = "";
        lstOrderList.DataSource = Orders.orderList;

        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "OrderNo";

        lstOrderList.DataBind();
    }
}