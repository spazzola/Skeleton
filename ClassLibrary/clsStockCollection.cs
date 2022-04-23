using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();

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
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }



        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("dbo.sproc_tblItem_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemDescription", mThisStock.ItemDescription);
            DB.AddParameter("@ItemPrice", mThisStock.ItemPrice);
            DB.AddParameter("@ItemAmount", mThisStock.ItemAmount);
            DB.AddParameter("@IsItemAvailable", mThisStock.ItemAvailable);
            DB.AddParameter("@NextShipment", mThisStock.ItemShipment);
            return DB.Execute("dbo.sproc_tblItem_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", mThisStock.ItemID);
            DB.AddParameter("@ItemDescription", mThisStock.ItemDescription);
            DB.AddParameter("@ItemPrice", mThisStock.ItemPrice);
            DB.AddParameter("@ItemAmount", mThisStock.ItemAmount);
            DB.AddParameter("@IsItemAvailable", mThisStock.ItemAvailable);
            DB.AddParameter("@NextShipment", mThisStock.ItemShipment);
            DB.Execute("dbo.sproc_tblItem_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("ItemId", mThisStock.ItemID);
            DB.Execute("dbo.sproc_tblOrderLine_FilterByItemId");
            if (DB.Count == 0)
            {
                clsDataConnection DataBase = new clsDataConnection();
                DataBase.AddParameter("Id", mThisStock.ItemID);
                DataBase.Execute("dbo.sproc_tblItem_Delete");
            }
        }

        public void ReportByDesc(string Desc)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemDescription", Desc);
            DB.Execute("dbo.sproc_tblItem_FilterByDesc");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStockList = new List<clsStock>();
            for (int x = 0; x < RecordCount; x++)
            {
                clsStock Stock = new clsStock();
                Stock.ItemID = Convert.ToInt32(DB.DataTable.Rows[x]["Id"]);
                Stock.ItemPrice = Convert.ToInt32(DB.DataTable.Rows[x]["ItemPrice"]);
                Stock.ItemDescription = DB.DataTable.Rows[x]["ItemDescription"].ToString();
                Stock.ItemAmount = Convert.ToInt32(DB.DataTable.Rows[x]["ItemAmount"]);
                Stock.ItemAvailable = Convert.ToBoolean(DB.DataTable.Rows[x]["IsItemAvailable"]);
                Stock.ItemShipment = Convert.ToDateTime(DB.DataTable.Rows[x]["NextShipment"]);
                mStockList.Add(Stock);
            }
        }
    }
}