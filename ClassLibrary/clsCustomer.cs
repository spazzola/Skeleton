using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public DateTime dateAdded;
        public int id { get; set; }
        public string name { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public bool exists { get; set; }
    }
}