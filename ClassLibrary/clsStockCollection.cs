using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }

        
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                
            }
        }
        public clsStock ThisStock { get; set; }


        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("dbo.sproc_tblItem_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock Stock = new clsStock();
                Stock.ItemID = Convert.ToInt32(DB.DataTable.Rows[Index]["Id"]);
                Stock.ItemDescription = Convert.ToString(DB.DataTable.Rows[Index]["ItemDescription"]);
                Stock.ItemPrice = float.Parse(Convert.ToString(DB.DataTable.Rows[Index]["ItemPrice"]));
                Stock.ItemAmount = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemAmount"]);
                Stock.ItemAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsItemAvailable"]);
                Stock.ItemShipment = Convert.ToDateTime(DB.DataTable.Rows[Index]["NextShipment"]);
                mStockList.Add(Stock);
                Index++;
            }
        }
    }
}