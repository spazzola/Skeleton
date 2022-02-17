using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool isDelivered { get; set; }
        public string OrderNo { get; set; }

        public int CustomerID { get; set; }

        public DateTime DatePurchased { get; set; }
        public double TotalPrice { get; set; }
    }
}