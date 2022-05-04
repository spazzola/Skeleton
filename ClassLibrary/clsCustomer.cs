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
        public string passwrd { 
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

        public bool tstExist;
        public bool exist { 
            get
            {
                return tstExist;
            }
            set
            {
                tstExist = value;
            } 
        }

        public bool Find(int id)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the id as parameter to the DB
            DB.AddParameter("@id", id);
            // Execute the procedure
            DB.Execute("sproc_tblCustomer_FilterById");
            // Check if DB has at least 1 row
            if(DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                testId = Convert.ToInt32(DB.DataTable.Rows[0]["id"]);
                testName = Convert.ToString(DB.DataTable.Rows[0]["name"]);
                testPass = Convert.ToString(DB.DataTable.Rows[0]["pass"]);
                testMail = Convert.ToString(DB.DataTable.Rows[0]["email"]);
                testDate = Convert.ToDateTime(DB.DataTable.Rows[0]["dateCreated"]);
                tstExist = Convert.ToBoolean(DB.DataTable.Rows[0]["exist"]);
                //return that everything works fine
                return true;
            }
            // if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Validate(string dateCreated,
            string email, string pass, string name)
        {
            string error = "";
            if(name.Length == 0)
            {
                error = "Name may not be blank\n";
            }

            if(name.Length >= 20)
            {
                error = "Name length should be less than 20(including spaces)\n";
            }

            try
            {
                testDate = Convert.ToDateTime(dateAdded);
                if (testDate < DateTime.Now.Date)
                {
                    error = "Date can't be in the past\n";
                }

                if (testDate > DateTime.Now.Date)
                {
                    error = "Date can't be in the future\n";
                }
            }
            catch
            {
                error = "The date provided was not a valid date.\n";
            }

            return error;
        }

        public string GetUserData()
        {
            string data = this.dateAdded.ToString() + "\n" 
                + this.name + "\n" + this.passwrd + "\n" 
                + this.email + "\n" + this.exist + "\n";
            return data;
        }
    }
}