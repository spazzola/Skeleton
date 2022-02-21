using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOfOK()
        {
            clsStock Stock = new clsStock();
            Assert.IsNotNull(Stock);
        }

        [TestMethod]
        public void DescriptionPropertyOK()
        {
            clsStock Stock = new clsStock();
            String Desc = "A red jumper";
            Stock.ItemDescription = Desc;
            Assert.AreEqual(Stock.ItemDescription, Desc);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsStock Stock = new clsStock();
            float price = 5.75f;
            Stock.ItemPrice = price;
            Assert.AreEqual(Stock.ItemPrice, price);
        }

        [TestMethod]
        public void AmountPropertyOK()
        {
            clsStock Stock = new clsStock();
            int amount = 10;
            Stock.ItemAmount = amount;
            Assert.AreEqual(Stock.ItemAmount, amount);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            clsStock Stock = new clsStock();
            Boolean IsAvailable = true;
            Stock.ItemAvailable = IsAvailable;
            Assert.AreEqual(Stock.ItemAvailable, IsAvailable);
        }

        [TestMethod]
        public void ShipmentPropertyOK()
        {
            clsStock Stock = new clsStock();
            DateTime date = DateTime.Now.Date;
            Stock.ItemShipment = date;
            Assert.AreEqual(Stock.ItemShipment, date);
        }
    }
}
