using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private int mItemID;
        private String mItemDescription;
        private float mItemPrice;
        private int mItemAmount;
        private Boolean mItemAvailable;
        private DateTime mItemShipment;
        public int ItemID
        {
            get
            {
                return mItemID;
            }
            set
            {
                mItemID = value;
            }

        }
        public string ItemDescription
        {
            get
            {
            return mItemDescription;
            }
            set
            {
                mItemDescription = value;
            }
        }
        public float ItemPrice
        {
            get
            {
                return mItemPrice;
            }
            set
            {
                mItemPrice = value;
            }
        }
        public int ItemAmount
        {
            get
            {
                return mItemAmount;
            }
            set
            {
                mItemAmount = value;
            }
        }
        public bool ItemAvailable
        {
            get
            {
                return mItemAvailable;
            }
            set
            {
                mItemAvailable = value;
            }
        }
        public DateTime ItemShipment
        {
            get
            {
                return mItemShipment;
            }
            set
            {
                mItemShipment = value;
            }
        }

        public bool Find(int ItemID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ID", ItemID);
            DB.Execute("dbo.sproc_tblItem_FilterById");
            if (DB.Count == 1)
            {
                mItemID = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mItemDescription = Convert.ToString(DB.DataTable.Rows[0]["ItemDescription"]);
                mItemPrice = float.Parse(Convert.ToString(DB.DataTable.Rows[0]["ItemPrice"]));
                mItemAmount = Convert.ToInt32(DB.DataTable.Rows[0]["ItemAmount"]);
                mItemAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["IsItemAvailable"]);
                mItemShipment = Convert.ToDateTime(DB.DataTable.Rows[0]["NextShipment"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string description, string price, string amount, string available, string shipment)
        {
            String Error = "";
            DateTime DateTemp;


            if (description.Length == 0)
            {
                Error = Error + "The description may not be blank : ";
            }

            if (description.Length > 50)
            {
                Error = Error + "The description must be 50 characters or less : ";
            }


            try
            {
                if (float.Parse(price) < 0)
                {
                    Error = Error + "The price may not be negative : ";
                }
            }
            catch
            {
                Error = Error + "The price must be a number : ";
            }


            try
            {
                if (int.Parse(amount) < 0)
                {
                    Error = Error + "The amount may not be negative : ";
                }
            }
            catch
            {
                Error = Error + "The amount must be an integer : ";
            }


            try
            {
                DateTemp = Convert.ToDateTime(shipment);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
            }
            catch
            {
                Error = Error + "The Shipment date was not a valid date : ";
            }

            return Error;
        }
    }
}