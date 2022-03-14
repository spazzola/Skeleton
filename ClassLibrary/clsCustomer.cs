using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public DateTime DateAdded;

        public int id { get; set; }
        public string name { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public bool exist { get; set; }
    }
}