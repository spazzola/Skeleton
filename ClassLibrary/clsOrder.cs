using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderID;
        private String mOrderNo;
        private Boolean mIsDelivered;
        private Int32 mCustomerID;
        private DateTime mDatePurchased;
        private Double mTotalPrice;


        public Int32 orderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }

        public bool isDelivered
        {
            get
            {
                return mIsDelivered;
            }
            set
            {
                mIsDelivered = value;
            }
        }


        public String orderNo
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }



        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        public DateTime DatePurchased
        {
            get
            {
                return mDatePurchased;
            }
            set
            {
                mDatePurchased = value;
            }
        }
        public Double TotalPrice {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }



        public bool Find(int orderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@id", orderID);

            DB.Execute("sproc_tblOrder_FilterById");

            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mIsDelivered = Convert.ToBoolean(DB.DataTable.Rows[0]["IsDelivered"]);
                mOrderNo = Convert.ToString(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mDatePurchased = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePurchased"]);
                mTotalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["TotalPrice"]);
                return true;
            }
            else
            {
                return false;
            }
        }


        public string Valid(string orderNo, string CustomerID, string DatePurchased)
        {

            String Error = "";
            DateTime DateTemp;

           

            if (orderNo.Length < 5)
            {
                Error += "OrderNo too small\n";

            }


            if (orderNo.Length > 10)
            {
                Error += "OrderNo too large\n";
            }

            try
            {
                if (CustomerID.Length < 1)
                {
                    Error += "Customer ID is too small\n";
                }


                if (CustomerID == "0")
                {
                    Error += "Invalid Entry for Customer ID\n";
                }

                if (CustomerID.Length >= 1000000000)
                {
                    Error += "Customer ID too large\n";
                }
            }
            catch
            {
                Error += "Invalid entry for customer\n";
            }

            try
            {
                DateTemp = Convert.ToDateTime(DatePurchased);
                

                if (DateTemp > DateTime.Now.Date)
                {
                    Error += "The date cannot be in the future\n";
                }

            }
            catch
            {
                Error += "The date was not a valid date\n";
            }

            return Error;
        }

        //d

        


    }
}