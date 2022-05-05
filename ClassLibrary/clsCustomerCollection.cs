using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        private List<clsCustomer> tstCustomerList = new List<clsCustomer>();
        public clsCustomer customer { get; set; }

        public List<clsCustomer> customersList { 
            get 
            {
                return tstCustomerList;
            } 
            set 
            {
                tstCustomerList = value;
            } 
        }

        public int count { 
            get 
            { 
                return tstCustomerList.Count;
            } 
            set 
            {

            } 
        }

        public clsCustomerCollection()
        {
            Int32 index = 0;

            Int32 recordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomer_SelectAll");

            recordCount = DB.Count;

            while(index < recordCount)
            {
                clsCustomer customer = new clsCustomer();

                customer.id = Convert.ToInt32(DB.DataTable.Rows[index]["id"]);
                customer.dateCreated = Convert.ToDateTime(DB.DataTable.Rows[index]["dateCreated"]);
                customer.name = Convert.ToString(DB.DataTable.Rows[index]["name"]);
                customer.email = Convert.ToString(DB.DataTable.Rows[index]["email"]);
                customer.passwrd = Convert.ToString(DB.DataTable.Rows[index]["pass"]);
                customer.exist = Convert.ToBoolean(DB.DataTable.Rows[index]["exist"]);

                tstCustomerList.Add(customer);

                index++;

            }
        }

        //clsCustomerCollection constructor
       /* public clsCustomerCollection()
        {
            clsCustomer customer = new clsCustomer();

            customer.id = 1;
            customer.dateCreated = DateTime.Now.Date;
            customer.name = "Chuck Norix";
            customer.email = "n0rix@mail.com";
            customer.passwrd = "asdfgh12";
            customer.exist = true;

            tstCustomerList.Add(customer);

            //Re-instantiate customer
            customer = new clsCustomer();

            customer.id = 2;
            customer.dateCreated = DateTime.Now.Date;
            customer.name = "6pax Shpaxanders";
            customer.email = "6pax@mail.com";
            customer.passwrd = "qwerty_2000s";
            customer.exist = true;

            tstCustomerList.Add(customer);
        }*/
    }
}