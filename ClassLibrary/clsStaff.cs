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
            mStaffId = 1;
            mFullName = "Jack Smith";
            mSalary = 10.0;
            mLogin = "jack00";
            mPassword = "smith25";
            mIsAdmin = true;
            mLastLogged = Convert.ToDateTime("01/01/2022");
            return true;
        }
    }
}