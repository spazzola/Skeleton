using System;

namespace ClassLibrary {
    public class clsStaff {
        public clsStaff() {
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
            set {
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
            }
            else {
                return false;
            }
        }

        public string Valid(string fullName, string login, string password, string lastLogged, string salary) {
            String error = "";
            DateTime dateTemp;

            if (fullName.Length == 0) {
                error += "Full name cannot be blank. ";
            }

            if (fullName.Length > 20) {
                error += "The full name must by less than 20 characters. ";
            }

            if (login.Length == 0) {
                error += "Login cannot be blank. ";
            }

            if (login.Length > 20) {
                error += "The login must by less than 20 characters. ";
            }

            if (password.Length == 0) {
                error += "Password cannot be blank. ";
            }

            if (password.Length > 30) {
                error += "The password must by less than 30 characters. ";
            }

            try {
                dateTemp = Convert.ToDateTime(lastLogged);
                if (dateTemp > DateTime.Now.Date) {
                    error += "The date cannot be greater than now. ";
                }
            }
            catch {
                error += "Invalid type of date variable. ";
            }

            try {
                if (Double.Parse(salary) < 0) {
                    error += "Salary cannot be less than 0. ";
                }

                if (Double.Parse(salary) > 1000000.00) {
                    error += "Salary cannot be greater than 1,000,000.00. ";
                }
            } catch {
                error += "Invalid type of double variable. ";
            }

            return error;
        }

    }
}