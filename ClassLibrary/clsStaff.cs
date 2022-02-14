using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public string fullName { get; set; }
        public double salary { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public bool isAdmin { get; set; }
        public DateTime lastLogged { get; set; }
    }
}