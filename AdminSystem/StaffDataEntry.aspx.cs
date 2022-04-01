using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page {

    Int32 staffId;

    protected void Page_Load(object sender, EventArgs e) {
        staffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false) {
            if (staffId != -1) {
                DisplayStaff();
            }
        }
    }

    void DisplayStaff() {
        clsStaffCollection allStaff = new clsStaffCollection();
        allStaff.thisStaff.Find(staffId);

        txtStaffId.Text = allStaff.thisStaff.staffId.ToString();
        txtLogin.Text = allStaff.thisStaff.login;
        txtPassword.Text = allStaff.thisStaff.password;
        txtSalary.Text = allStaff.thisStaff.salary.ToString();
        txtFullName.Text = allStaff.thisStaff.fullName;
        chkIsAdmin.Checked = allStaff.thisStaff.isAdmin;
        txtLastLogged.Text = allStaff.thisStaff.lastLogged.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e) {
        clsStaff staffMember = new clsStaff();
        Int32 staffId = Convert.ToInt32(txtStaffId.Text);
        string fullName = txtFullName.Text;
        string stringSalary = txtSalary.Text;
        string login = txtLogin.Text;
        string password = txtPassword.Text;
        string lastLogged = txtLastLogged.Text;
        Boolean isAdmin = chkIsAdmin.Checked;

        string error = "";
        error = staffMember.Valid(fullName, login, password, lastLogged, stringSalary);

        if (error == "") {
            staffMember.staffId = staffId;
            staffMember.fullName = fullName;
            staffMember.salary = Convert.ToDouble(stringSalary);
            staffMember.login = login;
            staffMember.password = password;
            staffMember.lastLogged = Convert.ToDateTime(lastLogged);
            staffMember.isAdmin = isAdmin;

            clsStaffCollection staffList = new clsStaffCollection();

            if (staffId == -1) {
                staffList.thisStaff = staffMember;
                staffList.Add();
            } else {
                staffList.thisStaff.Find(staffId);
                staffList.thisStaff = staffMember;
                staffList.Update();
            }
            Response.Redirect("StaffList.aspx");
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