using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public string ItemDescription { get; set; }
        public float ItemPrice { get; set; }
        public int ItemAmount { get; set; }
        public bool ItemAvailable { get; set; }
        public DateTime ItemShipment { get; set; }
    }
}