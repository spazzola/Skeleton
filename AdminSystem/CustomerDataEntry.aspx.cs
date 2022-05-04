using System;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonOK_Click(object sender, EventArgs e)
    {


        // Make an instance of clsCustomer
        clsCustomer customer = new clsCustomer();

        String addedDate = dateTxtBox.Text;
        String nm = nameTxtBox.Text;
        String pass = passTxtBox.Text;
        String mail = mailTxtBox.Text;

        String error = customer.Validate(addedDate, mail, pass, nm);
        if (error == "")
        {
            // sets id
            //customer.id = int.Parse(idTxtBox.Text);
            // sets customer.name to a provided input
            customer.name = nm;
            // sets pass to provided input
            customer.passwrd = passTxtBox.Text;
            // sets email to provided input
            customer.email = mail;
            // sets customer.exists to wether it exists or not
            customer.dateCreated = Convert.ToDateTime(addedDate);
            //sets DateAdded to DateTime
            customer.exist = (bool)checkExist.Checked;
            // store customer in session object
            Session["customer"] = customer;
            // navigate to the viewer page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = error;
        }
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
            dateTxtBox.Text = customer.dateCreated.ToString();
            nameTxtBox.Text = customer.name;
            mailTxtBox.Text = customer.email;
            passTxtBox.Text = customer.passwrd;
        }
    }
}