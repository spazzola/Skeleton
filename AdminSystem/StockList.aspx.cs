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
        DisplayStock();
    }

    void DisplayStock()
    {
        clsStockCollection AllStock = new clsStockCollection();
        lstStockList.DataSource = AllStock.StockList;
        lstStockList.DataValueField = "ItemId";
        lstStockList.DataTextField = "ItemDescription";
        lstStockList.DataBind();
    }
}