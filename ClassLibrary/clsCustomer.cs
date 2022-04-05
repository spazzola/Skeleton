using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private DateTime testDate;
        public DateTime dateAdded
        {
            get
            {
                return testDate;
            }
            set
            {
                testDate = value;
            }
        }
        private Int32 testId;
        public int id {
            get
            {
                // this line of code sends data out of the property
                return testId;
            }
            set
            {
                // this line of code allows data into the property
                testId = value;
            } 
        }

        private string testName;
        public string name {
            get 
            {
                return testName;
            }
            set
            {
                testName = value;
            }
                }

        private string testPass;
        public string pass { 
            get
            {
                return testPass;
            }
            set
            {
                testPass = value;
            }
               }

        private string testMail;
        public string email { 
            get
            {
                return testMail;
            }
            set
            {
                testMail = value;
            }
                }

        public bool maybe;
        public bool exists { 
            get
            {
                return maybe;
            }
            set
            {
                maybe = value;
            } 
        }

        public bool Find(int id)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@id", id);

            DB.Execute("sproc_tblCustomer_FilterById");

            if(DB.Count == 1)
            {
                testId = Convert.ToInt32(DB.DataTable.Rows[0]["id"]);
                testDate = Convert.ToDateTime(DB.DataTable.Rows[0]["dateAdded"]);
                testName = Convert.ToString(DB.DataTable.Rows[0]["name"]);
                testMail = Convert.ToString(DB.DataTable.Rows[0]["email"]);
                testPass = Convert.ToString(DB.DataTable.Rows[0]["pass"]);
                maybe = Convert.ToBoolean(DB.DataTable.Rows[0]["exist"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetUserData()
        {
            string data = this.dateAdded.ToString() + "\n" 
                + this.name + "\n" + this.pass + "\n" 
                + this.email + "\n" + this.exists + "\n";
            return data;
        }
    }
}