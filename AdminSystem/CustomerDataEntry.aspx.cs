using System;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    public clsCustomer customer;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // Create instance of clsCustomer
        //clsCustomer customer = new clsCustomer();
        // sets DateAdded to DateTime
        customer.dateAdded = DateTime.Parse(dateTxtBox.Text);
        // sets id to 1
        customer.id = int.Parse(idTxtBox.Text);
        // sets customer.name to a provided input
        customer.name = nameTxtBox.Text;
        // sets pass to provided input
        customer.pass = passTxtBox.Text;
        // sets email to provided input
        customer.email = mailTxtBox.Text;
        // store customer in session object
        Session["customer"] = customer;
        // navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void dateTxtBox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void idTxtBox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void nameTxtBox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void passTxtBox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void mailTxtBox_TextChanged(object sender, EventArgs e)
    {

    }
}