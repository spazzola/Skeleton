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
    }
}
