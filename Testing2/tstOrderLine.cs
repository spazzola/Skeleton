using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Assert.IsNotNull(AnOrderLine);
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
    }
}
