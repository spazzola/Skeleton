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

        [TestMethod]

        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.orderID = 1;
            TestItem.isDelivered = true;
            TestItem.orderNo = "1abc2def34";
            TestItem.CustomerID = 1;
            TestItem.DatePurchased = DateTime.Now.Date;
            TestItem.TotalPrice = 24.00;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);




        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.isDelivered = true;
            TestItem.orderNo = "1abc2def34";
            TestItem.CustomerID = 1;
            TestItem.DatePurchased = Convert.ToDateTime("25/03/2020 00:00");
            TestItem.TotalPrice = 24.00;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.orderID = PrimaryKey;

            TestItem.isDelivered = false;
            TestItem.orderNo = "5abc6def78";
            TestItem.CustomerID = 1;
            TestItem.DatePurchased = Convert.ToDateTime("25/03/2020 00:00");
            TestItem.TotalPrice = 30.00;

            AllOrders.ThisOrder = TestItem;

            AllOrders.Update();

            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);


        }

        [TestMethod]

        public void DeleteMethodOK()
        {

            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.isDelivered = true;
            TestItem.orderNo = "1ab2559";
            TestItem.CustomerID = 1;
            TestItem.DatePurchased = Convert.ToDateTime("25/03/2020 00:00");
            TestItem.TotalPrice = 25.00;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.orderID = PrimaryKey;

            AllOrders.ThisOrder.Find(PrimaryKey);

            AllOrders.Delete();

            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }


        [TestMethod]

        public void ReportByOrderNoMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrderCollection FilteredOrders = new clsOrderCollection();

            FilteredOrders.ReportByOrderNo("");

            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]

        public void ReportByOrderNoNotFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            FilteredOrders.ReportByOrderNo("yyyyyyy");

            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]

        public void ReportByOrderNoTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            Boolean OK = true;

            FilteredOrders.ReportByOrderNo("xxxxxxx");

            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.orderList[0].orderID != 40)
                {
                    OK = false;
                }
                if (FilteredOrders.orderList[1].orderID != 41)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
