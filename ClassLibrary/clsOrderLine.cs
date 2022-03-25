using System;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        public int mOrderLineID;
        private String mOrderNo;
        private Int32 mItemID;
        private Int32 mQuantity;
        private Double mTotalPrice;


        public int orderLineID
        {
            get
            {
                return mOrderLineID;

            }
            set
            {
                mOrderLineID = value;
            }
        }

        public string orderNo
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



        public int itemID
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
        public double TotalPrice
        {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }




        public bool Find(int orderLineID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", orderLineID);

            DB.Execute("sproc_tblOrderLine_FilterById");

            if (DB.Count == 1)
            {
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mOrderNo = Convert.ToString(DB.DataTable.Rows[0]["OrderNo"]);
                mItemID = Convert.ToInt32(DB.DataTable.Rows[0]["ItemId"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mTotalPrice = Convert.ToDouble(DB.DataTable.Rows[0]["TotalPrice"]);
                return true;
            }
            else
            {
                return false;
            }
        }

    }



}


  
    
