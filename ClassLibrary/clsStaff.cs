using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        private Int32 mStaffId;
        private string mFullName;
        private double mSalary;
        private string mLogin;
        private string mPassword;
        private bool mIsAdmin;
        private DateTime mLastLogged;

        public Int32 staffId {
            get {
                return mStaffId;
            }
            set {
                mStaffId = value;
            }
        }

        public string fullName { 
            get {
                return mFullName;
            }
            set {
                mFullName = value;
            }
        }

        public double salary {
            get {
                return mSalary;
            }
            set {
                mSalary = value;
            }
        }

        public string login {
            get {
                return mLogin;
            }
            set  {
                mLogin = value;
            }
        }

        public string password {
            get {
                return mPassword;
            }
            set {
                mPassword = value;
            }
        }

        public bool isAdmin {
            get {
                return mIsAdmin;
            }
            set {
                mIsAdmin = value;
            }
        }

        public DateTime lastLogged {
            get {
                return mLastLogged;
            }
            set {
                mLastLogged = value;
            }
        }

        public bool Find(int staffId) {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@id", staffId);
            DB.Execute("sproc_tblStaffMember_FilterById");

            if (DB.Count == 1) {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["id"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mSalary = Convert.ToDouble(DB.DataTable.Rows[0]["Salary"]);
                mLogin = Convert.ToString(DB.DataTable.Rows[0]["Login"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mIsAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAdmin"]);
                mLastLogged = Convert.ToDateTime(DB.DataTable.Rows[0]["LastLogged"]);

                return true;
            } else {
                return false;
            }
        }
    }
}