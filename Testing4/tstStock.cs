using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        String Description = "A red Jumper";
        String Price = 4.2f.ToString();
        String Amount = "10";
        String Available = "true";
        String Shipment = DateTime.Now.Date.ToString();

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

        [TestMethod]
        public void FindMethodOk()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Int32 StockNo = 1;
            Found = Stock.Find(StockNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestIdFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 1;
            Found = Stock.Find(ID);
            if (Stock.ItemID != ID)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDescFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 1;
            String Desc = "A red Jumper";
            Found = Stock.Find(ID);
            if (Stock.ItemDescription != Desc)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 1;
            float Price = 11.7f;
            Found = Stock.Find(ID);
            if (Stock.ItemPrice != Price)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAmountFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 1;
            int Amount = 30;
            Found = Stock.Find(ID);
            if (Stock.ItemAmount != Amount)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 1;
            Boolean Avail = true;
            Found = Stock.Find(ID);
            if (Stock.ItemAvailable != Avail)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShipmentFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 1;
            DateTime Shipment = Convert.ToDateTime("22/05/22");
            Found = Stock.Find(ID);
            if (Stock.ItemShipment != Shipment)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
        }

        [TestMethod]
        public void DescMinLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Description = "";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Description = "a";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescMinPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Description = "aa";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescMaxLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Description = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Description = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescMid()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Description = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DescMaxPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Description = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescExtremeMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Description = "";
            Description = Description.PadRight(500, 'a');
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Price = "";
            Price = "-100";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Price = "";
            Price = "-1";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Price = "";
            Price = "0";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Price = "";
            Price = "1";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Price = "This is not a float";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AmountExtremeMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Amount = "";
            Amount = "-100";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AmountMinLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Amount = "";
            Amount = "-1";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AmountMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Amount = "";
            Amount = "0";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AmountMinPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Amount = "";
            Amount = "1";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AmountInvalidData()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Amount = "This is not an int";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShipmentExtremeMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String Shipment = TestDate.ToString();
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShipmentMinLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            String Shipment = TestDate.ToString();
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShipmentMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            String Shipment = TestDate.ToString();
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShipmentMinPlusOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            String Shipment = TestDate.ToString();
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShipmentInvalidData()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            String Shipment = "This is not a date";
            Error = Stock.Valid(Description, Price, Amount, Available, Shipment);
            Assert.AreNotEqual(Error, "");
        }
    }
}
