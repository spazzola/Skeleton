using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder {



        String orderID = "1";
        String isDelivered = "true";
        String orderNo = "3abc4def56";
        String CustomerID = "1234567";
        String DatePurchased = DateTime.Now.Date.ToString();
        String TotalPrice = 20.00.ToString();
        
    
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

            AnOrder.orderNo = TestData;

            Assert.AreEqual(AnOrder.orderNo, TestData);
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

            String orderNo = "3abc4def56";

            Int32 orderID = 1;

            Found = AnOrder.Find(orderID);

            Assert.IsTrue(Found);


        }


        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderID = 1;
            Found = AnOrder.Find(orderID);

            if (AnOrder.orderID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrder AnOrder = new clsOrder();

            Boolean Found = false;


            Boolean OK = true;


            String orderNo = "1abc2def34";

            Int32 orderID = 1;

            Found = AnOrder.Find(orderID);

            if (AnOrder.orderNo != "1abc2def34")
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

            Int32 CustomerID = 123456;

            Int32 orderID = 1;


            Found = AnOrder.Find(orderID);

            if (AnOrder.CustomerID != 123456)
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

            Int32 orderID = 1;

            Found = AnOrder.Find(orderID);

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

            Double TotalPrice = 20.00;

            Int32 orderID = 1;

            Found = AnOrder.Find(orderID);

            if (AnOrder.TotalPrice != 20.00)
            {
                OK = false;
            }

            Assert.IsTrue(OK);


        }
    }
}
