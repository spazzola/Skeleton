
using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsOrderCollection
    {
        
        List<clsOrder> mOrderList = new List<clsOrder>();

        clsOrder mThisOrder = new clsOrder();


        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            //DB.AddParameter("@orderID", mThisOrder.orderID);
            DB.AddParameter("@isDelivered", mThisOrder.isDelivered);
            DB.AddParameter("@orderNo", mThisOrder.orderNo);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@DatePurchased", mThisOrder.DatePurchased);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);

            return DB.Execute("sproc_tblOrder_Insert");

        }

        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblOrder_SelectAll");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 RecordCount;

            

           

            RecordCount = DB.Count;

            mOrderList = new List<clsOrder>();  

            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();

                AnOrder.orderID = Convert.ToInt32(DB.DataTable.Rows[Index]["Id"]);
                AnOrder.isDelivered = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsDelivered"]);
                AnOrder.orderNo = Convert.ToString(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.TotalPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalPrice"]);

                mOrderList.Add(AnOrder);

                Index++;

            }
        }


        public List<clsOrder> orderList {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        
        }
        
        public int Count {
            get
            {
                return mOrderList.Count;

            }
            set
            {
                
            }
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@orderID", mThisOrder.orderID);
            DB.AddParameter("@isDelivered", mThisOrder.isDelivered);
            DB.AddParameter("@orderNo", mThisOrder.orderNo);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID); 
            DB.AddParameter("@DatePurchased", mThisOrder.DatePurchased);
            DB.AddParameter("@TotalPrice", mThisOrder.TotalPrice);

            DB.Execute("sproc_tblOrder_Update");
        }

        

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@orderID", mThisOrder.orderID);

            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByOrderNo(string orderNo)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@orderNo", orderNo);

            DB.Execute("sproc_tblOrder_FilterByOrderNo");

            PopulateArray(DB);
        }
    }
}