using System;
using System.Collections.Generic;

namespace ClassLibrary {
    public class clsStaffCollection {

        public clsStaffCollection() {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaffMember_SelectAll");
            PopulateArray(DB);
        }

        private List<clsStaff> mStaffList = new List<clsStaff>();
        public List<clsStaff> staffList { 
            get {
                return mStaffList;
            }
            set {
                mStaffList = value;
            }
        }

        public int count { 
            get {
                return mStaffList.Count;
            }
            set {

            }
        }
        clsStaff mThisStaff = new clsStaff();
        public clsStaff thisStaff { 
            get {
                return mThisStaff;
            }
            set {
                mThisStaff = value;
            }
        }

        public int Add() {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@FullName", mThisStaff.fullName);
            DB.AddParameter("@Login", mThisStaff.login);
            DB.AddParameter("@Password", mThisStaff.password);
            DB.AddParameter("@IsAdmin", mThisStaff.isAdmin);
            DB.AddParameter("@LastLogged", mThisStaff.lastLogged);
            DB.AddParameter("@Salary", mThisStaff.salary);

            return DB.Execute("sproc_tblStaffMember_Insert");
        }

        public void Update() {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Id", mThisStaff.staffId);
            DB.AddParameter("@FullName", mThisStaff.fullName);
            DB.AddParameter("@Login", mThisStaff.login);
            DB.AddParameter("@Password", mThisStaff.password);
            DB.AddParameter("@IsAdmin", mThisStaff.isAdmin);
            DB.AddParameter("@LastLogged", mThisStaff.lastLogged);
            DB.AddParameter("@Salary", mThisStaff.salary);

            DB.Execute("sproc_tblStaffMember_Update");
        }

        public void Delete() {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", mThisStaff.staffId);
            DB.Execute("sproc_tblStaffMember_Delete");
        }

        public void ReportByFullName(string fullName) {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FullName", fullName);
            DB.Execute("sproc_tblStaffMember_FilterByFullName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB) {
            Int32 index = 0;
            Int32 recordCount;
            recordCount = DB.Count;
            mStaffList = new List<clsStaff>();

            while (index < recordCount) {
                clsStaff staff = new clsStaff();
                staff.staffId = Convert.ToInt32(DB.DataTable.Rows[index]["Id"]);
                staff.fullName = Convert.ToString(DB.DataTable.Rows[index]["FullName"]);
                staff.login = Convert.ToString(DB.DataTable.Rows[index]["Login"]);
                staff.password = Convert.ToString(DB.DataTable.Rows[index]["Password"]);
                staff.lastLogged = Convert.ToDateTime(DB.DataTable.Rows[index]["LastLogged"]);
                staff.isAdmin = Convert.ToBoolean(DB.DataTable.Rows[index]["IsAdmin"]);

                mStaffList.Add(staff);
                index++;
            }
        }

    }
}