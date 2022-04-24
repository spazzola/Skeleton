using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        public clsSupplierCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("dbo.sproc_tblSupplier_SelectAll");
            PopulateArray(DB);
        }
        private List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();
        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }

        }
        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {
            }
        }

        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", mThisSupplier.Name);
            DB.AddParameter("@Email", mThisSupplier.Email);
            DB.AddParameter("@ProductDescription", mThisSupplier.ProductDescription);
            DB.AddParameter("@Quantity", mThisSupplier.Quantity);
            DB.AddParameter("@Availability", mThisSupplier.Availability);
            DB.AddParameter("@DateAvailable", mThisSupplier.DateAvailable);

            return DB.Execute("dbo.sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", mThisSupplier.SupplierId);
            DB.AddParameter("@Name", mThisSupplier.Name);
            DB.AddParameter("@Email", mThisSupplier.Email);
            DB.AddParameter("@ProductDescription", mThisSupplier.ProductDescription);
            DB.AddParameter("@Quantity", mThisSupplier.Quantity);
            DB.AddParameter("@Availability", mThisSupplier.Availability);
            DB.AddParameter("@DateAvailable", mThisSupplier.DateAvailable);
            DB.Execute("dbo.sproc_tblSupplier_Update");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", mThisSupplier.SupplierId);
            DB.Execute("dbo.sproc_tblSupplier_Delete");
        }

        public void ReportByName(string Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", Name);
            DB.Execute("sproc_tblSupplier_FilterByName");
            PopulateArray(DB);

        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mSupplierList = new List<clsSupplier>();
            while (Index < RecordCount)
            {
                clsSupplier Supplier = new clsSupplier();
                Supplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["Id"]);
                Supplier.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                Supplier.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                Supplier.Availability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                Supplier.ProductDescription = Convert.ToString(DB.DataTable.Rows[Index]["ProductDescription"]);
                Supplier.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                Supplier.DateAvailable = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAvailable"]);
                mSupplierList.Add(Supplier);
                Index++;
            }
        }
    }
}

    

     

        
