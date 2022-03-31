using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void AddressListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            List<clsOrder> TestList = new List<clsOrder>();

            clsOrder TestItem = new clsOrder();

            TestItem.orderID = 1;
            TestItem.isDelivered = true;
            TestItem.orderNo = "3abc4def56";
            TestItem.CustomerID = 1;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.TotalPrice = 20.00;

            TestList.Add(TestItem);

            AllOrders.orderList = TestList;

            Assert.AreEqual(AllOrders.orderList, TestList);
        }

        

        [TestMethod]

        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrder TestOrder = new clsOrder();

            TestOrder.orderID = 1;
            TestOrder.isDelivered = true;
            TestOrder.orderNo = "3abc4def56";
            TestOrder.CustomerID = 1;
            TestOrder.DatePurchased = DateTime.Now.Date;
            TestOrder.TotalPrice = 20.00;

            AllOrders.ThisOrder = TestOrder;

            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        

        [TestMethod]

        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            List<clsOrder> TestList = new List<clsOrder>();

            clsOrder TestItem = new clsOrder();

            TestItem.orderID = 1;
            TestItem.isDelivered = true;
            TestItem.orderNo = "3abc4def56";
            TestItem.CustomerID = 1;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.TotalPrice = 20.00;

            TestList.Add(TestItem);

            AllOrders.orderList = TestList;

            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }

    }
}
