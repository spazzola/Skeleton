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
        string staffId = txtStaffId.Text;
        string fullName = txtFullName.Text;
        string stringSalary = txtSalary.Text;
        string login = txtLogin.Text;
        string password = txtPassword.Text;
        string lastLogged = "12/02/2020 12:00";
        Boolean isAdmin = chkIsAdmin.Checked;

        string error = "";
        error = staffMember.Valid(fullName, login, password, lastLogged, stringSalary);

        if (error == "") {
            staffMember.staffId = Convert.ToInt32(staffId);
            staffMember.fullName = fullName;
            staffMember.salary = Convert.ToDouble(stringSalary);
            staffMember.login = login;
            staffMember.password = password;
            staffMember.lastLogged = Convert.ToDateTime(lastLogged);
            staffMember.isAdmin = isAdmin;

            Session["staffMember"] = staffMember;
            Response.Redirect("StaffViewer.aspx");
        } else {
            lblError.Text = error;
        }

        
    }

    protected void btnFind_Click(object sender, EventArgs e) {
        clsStaff staffMember = new clsStaff();
        Int32 staffId;
        Boolean found = false;
        staffId = Convert.ToInt32(txtStaffId.Text);
        found = staffMember.Find(staffId);

        if (found == true) {
            txtFullName.Text = staffMember.fullName;
            txtSalary.Text = staffMember.salary.ToString();
            txtLogin.Text = staffMember.login;
            txtPassword.Text = staffMember.password;
            chkIsAdmin.Checked = staffMember.isAdmin;
        }
    }
}