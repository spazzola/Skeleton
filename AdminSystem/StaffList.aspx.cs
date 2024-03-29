﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if (IsPostBack == false) {
            DisplayStaffs();
        }
    }

    void DisplayStaffs() {
        clsStaffCollection allStaff = new clsStaffCollection();
        lstStaffList.DataSource = allStaff.staffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "FullName";
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e) {
        Session["StaffId"] = -1;

        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e) {
        Int32 staffId;

        if (lstStaffList.SelectedIndex != -1) {
            staffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = staffId;
            Response.Redirect("StaffDataEntry.aspx");
        } else {
            lblError.Text = "Please select a record to edit from the list.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e) {
        Int32 staffId;

        if (lstStaffList.SelectedIndex != -1) {
            staffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = staffId;
            Response.Redirect("StaffConfirmDelete.aspx");
        } else {
            lblError.Text = "Please select a record to delete from the list";
        }
    }


    protected void Button1_Click(object sender, EventArgs e) {
        clsStaffCollection allStaff = new clsStaffCollection();
        allStaff.ReportByFullName(txtFullName.Text);
        lstStaffList.DataSource = allStaff.staffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "FullName";
        lstStaffList.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e) {
        clsStaffCollection allStaff = new clsStaffCollection();
        allStaff.ReportByFullName("");
        txtFullName.Text = "";
        lstStaffList.DataSource = allStaff.staffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "FullName";
        lstStaffList.DataBind();
    }
}