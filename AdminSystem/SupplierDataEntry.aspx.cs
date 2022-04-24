using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SupplierId;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierId = Convert.ToInt32(Session["SupplierId"]);
        if (IsPostBack == false)
        {
            if (SupplierId != -1)
            {
                DisplaySupplier();
            }
        }
    }
        void DisplaySupplier()
        {
            clsSupplierCollection Supplier = new clsSupplierCollection();
            Supplier.ThisSupplier.Find(SupplierId);
            txtSupplierId.Text = Supplier.ThisSupplier.SupplierId.ToString();
            txtName.Text = Supplier.ThisSupplier.Name;
            txtEmail.Text = Supplier.ThisSupplier.Email;
            txtProductDescription.Text = Supplier.ThisSupplier.ProductDescription;
            txtQuantity.Text = Convert.ToString(Supplier.ThisSupplier.Quantity);
            chkAvailability.Checked = Supplier.ThisSupplier.Availability;
            txtDateAvailable.Text = Supplier.ThisSupplier.DateAvailable.ToString();

        }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsSupplier Supplier = new clsSupplier();
        Int32 SupplierId = Convert.ToInt32(txtSupplierId.Text);
        string Name = txtName.Text;
        string Email = txtEmail.Text;
        Boolean Availability = chkAvailability.Checked;
        string Quantity = txtQuantity.Text;
        string ProductDescription = txtProductDescription.Text;
        string DateAvailable = txtDateAvailable.Text;
        string Error = "";
        Error = Supplier.Valid(Name, Email, ProductDescription, Quantity, DateAvailable);
        if (Error == "")
        {
            Supplier.SupplierId = SupplierId;
            Supplier.Name = Name;
            Supplier.Email = Email;
            Supplier.ProductDescription = ProductDescription;
            Supplier.Quantity = int.Parse(Quantity);
            Supplier.Availability = chkAvailability.Checked;
            Supplier.DateAvailable = Convert.ToDateTime(DateAvailable);
            clsSupplierCollection SupplierList = new clsSupplierCollection();
            if (SupplierId == -1)
            {
                SupplierList.ThisSupplier = Supplier;
                SupplierList.Add();
            }
            else
            {
                SupplierList.ThisSupplier.Find(SupplierId);
                SupplierList.ThisSupplier = Supplier;
                SupplierList.Update();
            }
            Response.Redirect("SupplierList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }




    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier Supplier = new clsSupplier();
        Int32 SupplierId;
        Boolean Found = false;
        SupplierId = Convert.ToInt32(txtSupplierId.Text);
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

