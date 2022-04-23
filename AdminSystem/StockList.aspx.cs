using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    private int selectedIndex = -1;
    private string selectedKey= "3";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        clsStockCollection AllStock = new clsStockCollection();
        lstStockList.DataSource = AllStock.StockList;
        lstStockList.DataValueField = "ItemId";
        lstStockList.DataTextField = "ItemDescription";
        lstStockList.DataBind();
    }

    protected void btnEdit_Click1(object sender, EventArgs e)
    {
        Int32 ItemId;
        if (selectedIndex != -1)
        {
            ItemId = Convert.ToInt32(selectedKey);
            Session["ItemId"] = ItemId;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnAdd_Click1(object sender, EventArgs e)
    {
        Session["ItemId"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstStockList.SelectedIndex != -1)
        {
            selectedIndex = lstStockList.SelectedIndex;
            selectedKey = lstStockList.SelectedValue;
        }
       
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 id;
        if (selectedIndex != -1)
        {
            id = Convert.ToInt32(selectedKey);
            Session["ItemId"] = id;
            Response.Redirect("StockConfirmDelete.aspx");
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection FilteredStock = new clsStockCollection();
        FilteredStock.ReportByDesc(txtFilter.Text);
        lstStockList.DataSource = FilteredStock.StockList;
        lstStockList.DataValueField = "ItemId";
        lstStockList.DataTextField = "ItemDescription";
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection AllStock = new clsStockCollection();
        lstStockList.DataSource = AllStock.StockList;
        lstStockList.DataValueField = "ItemId";
        lstStockList.DataTextField = "ItemDescription";
        lstStockList.DataBind();
        txtFilter.Text = "";
    }
}