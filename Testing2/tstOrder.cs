using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder {

        string orderNo = "3abc4def56";
        string CustomerID = "1234567";
        string DatePurchased = DateTime.Now.Date.ToString();
        
        
    
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


            

            Int32 orderID = 1;

            Found = AnOrder.Find(orderID);

            if (AnOrder.orderNo != "3abc4def56")
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

            

            Int32 orderID = 1;


            Found = AnOrder.Find(orderID);

            if (AnOrder.CustomerID != 1)
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

            

            Int32 orderID = 1;

            Found = AnOrder.Find(orderID);

            if (AnOrder.DatePurchased != Convert.ToDateTime("25/03/2022 00:00:00"))
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

            

            Int32 orderID = 1;

            Found = AnOrder.Find(orderID);

            if (AnOrder.TotalPrice != 20.00)
            {
                OK = false;
            }

            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();

            String error = "";



            error = AnOrder.Valid(orderNo, CustomerID, DatePurchased);

            Assert.AreEqual(error, "");
        }


        [TestMethod]

        public void orderNoMinLow()
        {
            clsOrder AnOrder = new clsOrder();

            String error = "";

            string orderNo = "1ab";

            error = AnOrder.Valid(orderNo, CustomerID, DatePurchased);

            Assert.AreNotEqual(error, "");

            

            
        }

        [TestMethod]

        public void orderNoMinBoundary()
        {
            clsOrder AnOrder = new clsOrder();

            String error = "";

            string orderNo = "1abc2";

            error = AnOrder.Valid(orderNo, CustomerID, DatePurchased);

            Assert.AreEqual(error, "");




        }

        [TestMethod]

        public void orderNoMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();

            String error = "";

            string orderNo = "1abc2d";

            error = AnOrder.Valid(orderNo, CustomerID, DatePurchased);

            Assert.AreEqual(error, "");




        }

        [TestMethod]

        public void orderNoMaxMinusOne()
        {
            clsOrder AnOrder = new clsOrder();

            String error = "";

            string orderNo = "1abc2def3";

            error = AnOrder.Valid(orderNo, CustomerID, DatePurchased);

            Assert.AreEqual(error, "");




        }

        [TestMethod]

        public void orderNoMaxBoundary()
        {
            clsOrder AnOrder = new clsOrder();

            String error = "";

            string orderNo = "1abc2def3g";

            error = AnOrder.Valid(orderNo, CustomerID, DatePurchased);

            Assert.AreEqual(error, "");




        }

        [TestMethod]

        public void orderNoMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();

            String error = "";

            String orderNo = "1abc2def3gh";

            error = AnOrder.Valid(orderNo, CustomerID, DatePurchased);

            Assert.AreNotEqual(error, "");




        }

        [TestMethod]

        public void orderExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();

            String error = "";

            String orderNo = "aaaaaaaaaaaaaaaaaaaa";

            error = AnOrder.Valid(orderNo, CustomerID, DatePurchased);

            Assert.AreNotEqual(error, "");




        }

        [TestMethod]

        public void CustomerIDMinLen()
        {
            clsOrder AnOrder = new clsOrder();
            String error = "";
            String CustomerID = "";

           
            error = AnOrder.Valid(orderNo, CustomerID, DatePurchased);
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]

        public void CustomerIDMinVal()
        {
            clsOrder AnOrder = new clsOrder();
            String error = "";
            Int32 testCustomer = 0;
            string CustomerID = testCustomer.ToString();
            error = AnOrder.Valid(orderNo, CustomerID, DatePurchased);
            Assert.AreNotEqual(error, "");

        }

        [TestMethod]

        public void CustomerInvalid()
        {
            clsOrder AnOrder = new clsOrder();
            String error = "";
            String CustomerID = "some string";
            error = AnOrder.Valid(orderNo, CustomerID, DatePurchased);
            Assert.AreEqual(error, "");
        }

        

        

        [TestMethod]

        public void DatePurchasedMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            string DatePurchased = testDate.ToString();

            Error = AnOrder.Valid(orderNo, CustomerID, DatePurchased);

            Assert.AreEqual(Error, "");


        }

        [TestMethod]

        public void DatePurchasedMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddSeconds(1);
            string DatePurchased = testDate.ToString();

            error = AnOrder.Valid(orderNo, CustomerID, DatePurchased);

            Assert.AreNotEqual(error, "");


        }


        [TestMethod]

        public void DatePurchasedExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String error = "";
            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(50);
            string DatePurchased = testDate.ToString();

            error = AnOrder.Valid(orderNo, CustomerID, DatePurchased);

            Assert.AreNotEqual(error, "");


        }

        

        

    }

    
}
