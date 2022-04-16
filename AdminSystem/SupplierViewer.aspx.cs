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
        clsSupplier Supplier = new clsSupplier();
        Supplier = (clsSupplier)Session["Supplier"];
        Response.Write(Supplier.SupplierId);
        Response.Write(Supplier.Name);
        Response.Write(Supplier.Email);
        Response.Write(Supplier.Availability);
        Response.Write(Supplier.Quantity);
        Response.Write(Supplier.ProductDescription);
        Response.Write(Supplier.DateAvailable);
        
    }
}