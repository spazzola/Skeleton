using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();

            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void isDeliveredOK()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean TestData = true;

            AnOrder.isDelivered = TestData;

            Assert.AreEqual(AnOrder.isDelivered, TestData);
        }

        public void isOrderNoOK()
        {
            clsOrder AnOrder = new clsOrder();

            String TestData = "2bcd6acb67";

            AnOrder.OrderNo = TestData;

            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        public void isCustomerIDOK()
        {
            clsOrder AnOrder = new clsOrder();

            Int32 TestData = 1234567;

            AnOrder.CustomerID = TestData;

            Assert.AreEqual(AnOrder.CustomerID, TestData);




        }

        public void isDatePurchasedOK()
        {
            clsOrder AnOrder = new clsOrder();

            DateTime TestData = DateTime.Now.Date;

            AnOrder.DatePurchased = TestData;

            Assert.AreEqual(AnOrder.DatePurchased, TestData);
        }

        public void isTotalPriceOK()
        {
            clsOrder AnOrder = new clsOrder();

            Double TestData = 20.50;

            AnOrder.TotalPrice = TestData;

            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }
    }
}
