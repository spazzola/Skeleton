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
            testId = 3401;
            testDate = new DateTime(2041, 3, 1, 7, 0, 0);
            testName = "Shpaximirr Maxan";
            testMail = "shpaximir@mail.com";
            testPass = "asdfgh12";
            maybe = true;
            return true;
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