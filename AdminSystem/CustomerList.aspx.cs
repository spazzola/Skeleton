using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        clsCustomerCollection customers = new clsCustomerCollection();

        lstCustomerList.DataSource = customers.customersList;
        lstCustomerList.DataValueField = "id";
        lstCustomerList.DataTextField = "name";

        lstCustomerList.DataBind();
    }

    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["Id"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void EditBtn_Click(object sender, EventArgs e)
    {
        Int32 id;

        if(lstCustomerList.SelectedIndex != -1)
        {
            id = Convert.ToInt32(lstCustomerList.SelectedValue);

            Session["Id"] = id;

            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Select a record to edit from the list.";
        }
    }
}