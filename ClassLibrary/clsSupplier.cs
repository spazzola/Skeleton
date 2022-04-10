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

                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
