
using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsOrderCollection
    {
        
        List<clsOrder> mOrderList = new List<clsOrder>();

        public clsOrderCollection()
        {
            int Index = 0;

            int RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblOrder_SelectAll");

            RecordCount = DB.Count;

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
        public clsOrder ThisOrder { get; set; }
        public int Count {
            get
            {
                return mOrderList.Count;

            }
            set
            {
                
            }
        }
    }
}