using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace ClassLibrary

{

    public class clsSupplier

    {

        private string mName;

        public string Name

        {

            get

            {

                return mName;

            }

            set

            {

                mName = value;

            }

        }

        private string mEmail;

        public string Email

        {

            get

            {

                return mEmail;

            }

            set

            {

                mEmail = value;

            }

        }

        private int mSupplierId;

        public int SupplierId

        {

            get

            {

                return mSupplierId;

            }

            set

            {

                mSupplierId = value;

            }

        }

        private bool mAvailability;

        public bool Availability

        {

            get

            {

                return mAvailability;

            }

            set

            {

                mAvailability = value;

            }

        }
        private DateTime mDateAvailable;

        public DateTime DateAvailable

        {

            get

            {

                return mDateAvailable;

            }

            set

            {

                mDateAvailable = value;

            }

        }

        private int mQuantity;

        public int Quantity

        {

            get

            {

                return mQuantity;

            }

            set

            {

                mQuantity = value;

            }

        }

        private string mProductDescription;

        public string ProductDescription

        {

            get

            {

                return mProductDescription;

            }

            set

            {

                mProductDescription = value;

            }

        }

        public bool Find(int SupplierId)
        {

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("Id", SupplierId);

            DB.Execute("dbo.Sproc_tblSupplier_FilterById");

            if (DB.Count == 1)

            {

                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);

                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);

                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);

                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);

                mProductDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);

                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mDateAvailable = Convert.ToDateTime(DB.DataTable.Rows[0]["Dateavailable"]);

                return true;

            }
            else
            {
                return false;
            }
        }

        public string Valid(string name, string email, string productDescription, string availability, string quantity, string dateAvailable)
        {
            String Error = "";
            DateTime DateTemp;

            if (name.Length == 0)
            {
                Error = Error + "Name may not be blank : ";
            }
            if (name.Length > 50)
            {
                Error = Error + "The name must be less than 50 characters : ";
            }

            if (productDescription.Length == 0)
            {
                Error = Error + "The product description may not be blank :";
            }
            if (productDescription.Length > 50)
            {
                Error = Error + "The product description must be less than 50 characters :";
            }


            if (email.Length == 0)
            {
                Error = Error + "Email may not be blank : ";
            }
            if (email.Length > 30)
            {
                Error = Error + "The email must be less than 30 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(dateAvailable);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not valid date : ";
            }
            try {

                if (int.Parse(quantity) < 0)
                {
                    Error = Error + "The quantity must not be less than 0:";
                }

                if (int.Parse(quantity) > 20000)
                {
                    Error = Error + "The quantity is too big :";
                }
            }
            catch
            {
                Error = Error + "Invalid quantity entered :";
            }

          
            
          return Error;

                 
        }
    }                                               
}
    

