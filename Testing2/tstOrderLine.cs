using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrderLine
    {

        String orderLineID = "1";
        String orderNo = "3abc4def56";
        String itemID = "123456";
        String Quantity = "14";
        String TotalPrice = 20.00.ToString();
        


        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]

        public void orderLineIDOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            int TestData = 1;

            AnOrderLine.orderLineID = TestData;

            Assert.AreEqual(AnOrderLine.orderLineID, TestData);

        }


        [TestMethod]
        public void orderNoOK()
        {

            clsOrderLine AnOrderLine = new clsOrderLine();

            String TestData = "3abd3fjd89";

            AnOrderLine.orderNo = TestData;

            Assert.AreEqual(AnOrderLine.orderNo, TestData);

        }

        [TestMethod]
        public void itemIDOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Int32 TestData = 123456;

            AnOrderLine.itemID = TestData;

            Assert.AreEqual(AnOrderLine.itemID, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Int32 TestData = 5;

            AnOrderLine.Quantity = TestData;

            Assert.AreEqual(AnOrderLine.Quantity, TestData);
        }

        [TestMethod]
        public void TotalPriceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Double TestData = 20.00;

            AnOrderLine.TotalPrice = TestData;

            Assert.AreEqual(AnOrderLine.TotalPrice, TestData);
        }


        [TestMethod]

        public void FindMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean Found = false;

            Int32 orderLineID = 1;

            Found = AnOrderLine.Find(orderLineID);

            Assert.IsTrue(Found);
        }


        [TestMethod]

        public void TestOrderLineNotFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean Found = false;

            Boolean OK = true;

            String OrderNo = "3abc4def56";

            Int32 orderLineID = 1;

            Found = AnOrderLine.Find(orderLineID);

            if (AnOrderLine.orderNo != "3abc4def56")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestItemIDFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean Found = false;

            Boolean OK = true;

            Int32 itemID = 123456;

            Int32 orderLineID = 1;

            Found = AnOrderLine.Find(orderLineID);

            if (AnOrderLine.itemID != 123456)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestQuantityFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean Found = false;

            Boolean OK = true;

            Int32 Quantity = 5;

            Int32 orderLineID = 1;

            Found = AnOrderLine.Find(orderLineID);

            if (AnOrderLine.Quantity != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestTotalPriceFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean Found = false;

            Boolean OK = true;

            Double TotalPrice = 20.00;

            Int32 orderLineID = 1;

            Found = AnOrderLine.Find(orderLineID);

            if (AnOrderLine.TotalPrice != 20.00)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
