using System;
namespace ClassLibrary
{
    public class clsAccount
    {
        private int id;
        private string u_name;
        private string pass;
        private string email;
        private bool exist;
        private DateTime date;

        public clsAccount()
        {
            id = 1;
            u_name = "user";
            pass = "";
            email = "";
            exist = true;
            date = new DateTime();
        }
    }
}