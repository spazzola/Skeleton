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

    protected void btnOK_Click(object sender, EventArgs e) {
        clsStaff staffMember = new clsStaff();
        staffMember.fullName = txtFullName.Text;
        staffMember.salary = Convert.ToDouble(txtSalary.Text);
        staffMember.login = txtLogin.Text;
        staffMember.password = txtPassword.Text;
        staffMember.isAdmin = chkIsAdmin.Checked;

        Session["staffMember"] = staffMember;
        Response.Redirect("StaffViewer.aspx");
    }
}