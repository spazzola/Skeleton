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

    protected void btnOk_Click(object sender, EventArgs e)

    {
        clsSupplier Supplier = new clsSupplier();
        string SupplierId = txtId.Text;
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        string Availability = chkAvailability.Checked.ToString();
        string Quantity = txtQuantity.Text;
        string ProductDescription = txtProductDescription.Text;
        string DateAvailable = txtDateAvailable.Text;
        Session["Supplier"] = Supplier;
        Response.Redirect("SupplierViewer.aspx");




    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier Supplier = new clsSupplier();
        int SupplierId;
        Boolean Found = false;
        SupplierId = Convert.ToInt32(txtId.Text);
        Found = Supplier.Find(SupplierId);
        if (Found == true)
        {
            txtName.Text = Supplier.Name;
            txtEmail.Text = Supplier.Email;
            txtProductDescription.Text = Supplier.ProductDescription;
            txtQuantity.Text = Convert.ToString(Supplier.Quantity);
            chkAvailability.Checked = Supplier.Availability;
            txtDateAvailable.Text = Supplier.DateAvailable.ToString();

        }
    }
}

