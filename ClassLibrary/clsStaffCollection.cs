using System;
using System.Collections.Generic;

namespace ClassLibrary {
    public class clsStaffCollection {

        public clsStaffCollection() {
            Int32 index = 0;
            Int32 recordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaffMember_SelectAll");
            recordCount = DB.Count;

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
        public clsStaff thisStaff { get; set; }

    }
}