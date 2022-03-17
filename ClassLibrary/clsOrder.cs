using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        private String mOrderNo;

        public String OrderNo
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

        public bool isDelivered { get; set; }
        

        public int CustomerID { get; set; }

        public DateTime DatePurchased { get; set; }
        public double TotalPrice { get; set; }

        public bool Find(string orderNo)
        {
            mOrderNo = "1abc2def34";

            return true;
        }

        public bool Find(int customerID)
        {
            return true;
        }

        public bool Find(DateTime DatePurchased)
        {
            return true;
        }

        public bool Find(double totalPrice)
        {
            return true;
        }
    }
}