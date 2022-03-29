using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public Date dateAdded;
        public int id { get; set; }
        public string name { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public bool exists { get; set; }

        public bool Find(int id)
        {
            bool found;
            return found;
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