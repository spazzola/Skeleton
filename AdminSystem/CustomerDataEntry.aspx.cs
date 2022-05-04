using System;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // Make an instance of clsCustomer
        clsCustomer customer = new clsCustomer();
        //sets DateAdded to DateTime
        customer.dateAdded = DateTime.Now.Date;
        // sets id
        customer.id = int.Parse(idTxtBox.Text);
        // sets customer.name to a provided input
        customer.name = nameTxtBox.Text;
        // sets pass to provided input
        customer.passwrd = passTxtBox.Text;
        // sets email to provided input
        customer.email = mailTxtBox.Text;
        // sets customer.exists to wether it exists or not
        customer.exist = (bool)checkExist.Checked;
        // store customer in session object
        Session["customer"] = customer;
        // navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }

   

    protected void passTxtBox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void mailTxtBox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void checkExist_CheckedChanged(object sender, EventArgs e)
    {
        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer customer = new clsCustomer();
        Int32 id = 0;
        Boolean found = false;
        if (!idTxtBox.Text.Equals(""))
        {
            id = Convert.ToInt32(idTxtBox.Text);
        }
        found = customer.Find(id);

        if (found == true)
        {
            idTxtBox.Text = customer.id.ToString();
            dateTxtBox.Text = customer.dateAdded.ToString();
            nameTxtBox.Text = customer.name;
            mailTxtBox.Text = customer.email;
            passTxtBox.Text = customer.passwrd;
        }
    }
}