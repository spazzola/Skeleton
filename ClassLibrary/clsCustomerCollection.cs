using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> tstCustomerList = new List<clsCustomer>();

        clsCustomer tstCustomer = new clsCustomer();

        public clsCustomer thisCustomer { 
            get 
            {
                return tstCustomer;
            } 
            set 
            {
                tstCustomer = value;
            }
        }

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

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("Id", tstCustomer.id);
            DB.AddParameter("name", tstCustomer.name);
            DB.AddParameter("pass", tstCustomer.passwrd);
            DB.AddParameter("email", tstCustomer.email);
            DB.AddParameter("exist", tstCustomer.exist);
            DB.AddParameter("dateCreated", tstCustomer.dateCreated);

            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("Id", tstCustomer.id);
            DB.AddParameter("dateCreated", tstCustomer.dateCreated);
            DB.AddParameter("name", tstCustomer.name);
            DB.AddParameter("email", tstCustomer.email);
            DB.AddParameter("pass", tstCustomer.passwrd);
            DB.AddParameter("exist", tstCustomer.exist);

            DB.Execute("sproc_tblCustomer_Update");
        }
    }
}