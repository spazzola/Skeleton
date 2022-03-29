using System;

namespace ClassLibrary
{
    public class clsCustomer
    {

        private Int32 idToFind;
        public DateTime dateAdded;
        public int id {
            get
            {
                // this line of code sends data out of the property
                return idToFind;
            }
            set
            {
                // this line of code allows data into the property
                idToFind = value;
            } 
        }
        public string name { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public bool exists { get; set; }

        public bool Find(int id)
        {
            idToFind = 3401;
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