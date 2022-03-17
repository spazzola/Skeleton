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

        [TestMethod]
        public void isOrderNoOK()
        {
            clsOrder AnOrder = new clsOrder();

            String TestData = "2bcd6acb67";

            AnOrder.OrderNo = TestData;

            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void isCustomerIDOK()
        {
            clsOrder AnOrder = new clsOrder();

            Int32 TestData = 1234567;

            AnOrder.CustomerID = TestData;

            Assert.AreEqual(AnOrder.CustomerID, TestData);




        }

        [TestMethod]
        public void isDatePurchasedOK()
        {
            clsOrder AnOrder = new clsOrder();

            DateTime TestData = DateTime.Now.Date;

            AnOrder.DatePurchased = TestData;

            Assert.AreEqual(AnOrder.DatePurchased, TestData);
        }

        [TestMethod]
        public void isTotalPriceOK()
        {
            clsOrder AnOrder = new clsOrder();

            Double TestData = 20.50;

            AnOrder.TotalPrice = TestData;

            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            String OrderNo = "3abc4def56";

            Found = AnOrder.Find(OrderNo);

            Assert.IsTrue(Found);


        }


        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            String OrderNo = "1abc2def34";

            Found = AnOrder.Find(OrderNo);

            if (AnOrder.OrderNo != "1abc2def34")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerID = 12345;

            Found = AnOrder.Find(CustomerID);

            if (AnOrder.CustomerID != 12345)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDatePurchasedOK()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            DateTime DatePurchased = DateTime.Now.Date;

            Found = AnOrder.Find(DatePurchased);

            if (AnOrder.DatePurchased != DateTime.Now.Date)
            {
                OK = false;
            }

            Assert.IsTrue(OK);


        }

        [TestMethod]

        public void TotalPriceOK()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            Double TotalPrice = 12.99;

            Found = AnOrder.Find(TotalPrice);

            if (AnOrder.TotalPrice != 12.99)
            {
                OK = false;
            }

            Assert.IsTrue(OK);


        }
    }
}
