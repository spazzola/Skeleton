using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOk()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.ItemID = 1;
            TestItem.ItemPrice = 4.5f;
            TestItem.ItemDescription = "A black hoodie";
            TestItem.ItemAvailable = true;
            TestItem.ItemAmount = 27;
            TestItem.ItemShipment = Convert.ToDateTime("25/06/22");
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.ItemID = 1;
            TestStock.ItemPrice = 4.5f;
            TestStock.ItemDescription = "A black hoodie";
            TestStock.ItemAvailable = true;
            TestStock.ItemAmount = 27;
            TestStock.ItemShipment = Convert.ToDateTime("25/06/22");
            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.ItemID = 1;
            TestItem.ItemPrice = 4.5f;
            TestItem.ItemDescription = "A black hoodie";
            TestItem.ItemAvailable = true;
            TestItem.ItemAmount = 27;
            TestItem.ItemShipment = Convert.ToDateTime("25/06/22");
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.ItemID = 1;
            TestItem.ItemDescription = "Blue Hat";
            TestItem.ItemAvailable = true;
            TestItem.ItemAmount = 34;
            TestItem.ItemPrice = 7.99f;
            TestItem.ItemShipment = Convert.ToDateTime("22/06/22");
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.ItemID = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.ItemDescription = "Blue Hat";
            TestItem.ItemAvailable = true;
            TestItem.ItemAmount = 34;
            TestItem.ItemPrice = 7.99f;
            TestItem.ItemShipment = Convert.ToDateTime("22/06/22");
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.ItemID = PrimaryKey;
            TestItem.ItemDescription = "Black Shorts";
            TestItem.ItemAvailable = false;
            TestItem.ItemAmount = 0;
            TestItem.ItemPrice = 13f;
            TestItem.ItemShipment = Convert.ToDateTime("27/09/22");
            AllStock.ThisStock = TestItem;
            AllStock.Update();
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock Stock = new clsStock();
            Int32 PrimaryKey = 0;
            Stock.ItemID = 1;
            Stock.ItemAmount = 1;
            Stock.ItemAvailable = true;
            Stock.ItemDescription = "a";
            Stock.ItemPrice = 1;
            Stock.ItemShipment = DateTime.Now.Date;
            AllStock.ThisStock = Stock;
            PrimaryKey = AllStock.Add();
            Stock.ItemID = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            AllStock.Delete();
            Boolean found = AllStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void ReportByDescMethodOk()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportByDesc("");
            Assert.AreEqual(FilteredStock.Count, AllStock.Count);
        }

        [TestMethod]
        public void ReportByDescFindNone()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportByDesc("xxy xxz yya");
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByDescTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            Boolean OK = true;
            FilteredStock.ReportByDesc("Red Socks");
            if (FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[0].ItemID != 38)
                {
                    OK = false;
                }
                if (FilteredStock.StockList[1].ItemID != 39)
                {
                    OK = false;
                }
            } else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
