using ClassLibrary;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace Testing6

{

    [TestClass]

    public class tstSupplier

    {
        string Name = "EddieStobart";
        string Email = "EddieStobart@gmail.com";
        string Availability = "bit";
        string Quantity = "1";
        string ProductDescription = "NikeTrackSuits";
        string DateAvailable = DateTime.Now.Date.ToString();

        [TestMethod]

        public void InstanceOk()

        {

            clsSupplier Supplier = new clsSupplier();

            Assert.IsNotNull(Supplier);

        }

        [TestMethod]

        public void SupplierIdPropertyOk()

        {

            clsSupplier Supplier = new clsSupplier();

            int TestData = 1;

            Supplier.SupplierId = TestData;

            Assert.AreEqual(Supplier.SupplierId, TestData);
        }


        [TestMethod]

        public void NamePropertyOK()

        {

            clsSupplier Supplier = new clsSupplier();

            string TestData = "EddieStobart";

            Supplier.Name = TestData;

            Assert.AreEqual(Supplier.Name, TestData);

        }

        [TestMethod]

        public void EmailPropertyOk()

        {

            clsSupplier Supplier = new clsSupplier();

            String TestData = "EddieStobart@gmail.com";

            Supplier.Email = TestData;

            Assert.AreEqual(Supplier.Email, TestData);

        }

        [TestMethod]

        public void AvailabilityPropertyOk()

        {

            clsSupplier Supplier = new clsSupplier();

            Boolean TestData = true;

            Supplier.Availability = TestData;

            Assert.AreEqual(Supplier.Availability, TestData);

        }

        [TestMethod]

        public void QuantityPropertyOk()

        {

            clsSupplier Supplier = new clsSupplier();

            int TestData = 1;

            Supplier.Quantity = TestData;

            Assert.AreEqual(Supplier.Quantity, TestData);

        }

        [TestMethod]

        public void ProductDescriptionPropertyOk()

        {

            clsSupplier Supplier = new clsSupplier();

            String TestData = "NikeTrackSuits";

            Supplier.ProductDescription = TestData;

            Assert.AreEqual(Supplier.ProductDescription, TestData);

        }
        [TestMethod]
        public void DateAvailablePropertyOK()
        {
            clsSupplier Supplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            Supplier.DateAvailable = TestData;
            Assert.AreEqual(Supplier.DateAvailable, TestData);
        }
        [TestMethod]
        public void FindMethodOk()
        {

            clsSupplier Supplier = new clsSupplier();

            Boolean Found = false;

            int SupplierId = 1;

            Found = Supplier.Find(SupplierId);

            Assert.IsTrue(Found);

        }

        [TestMethod]

        public void TestIdFound()

        {
            clsSupplier Supplier = new clsSupplier();

            Boolean Found = false;

            Boolean Ok = true;

            int Id = 1;

            Found = Supplier.Find(Id);

            if (Supplier.SupplierId != 1)

            {

                Ok = false;

            }

            Assert.IsTrue(Ok);

        }

        [TestMethod]

        public void TestNameFound()

        {

            clsSupplier Supplier = new clsSupplier();

            Boolean Found = false;

            Boolean OK = true;

            int SupplierId = 1;

            Found = Supplier.Find(SupplierId);

            if (Supplier.Name != "EddieStobart")

            {

                OK = false;

            }

            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestEmailFound()

        {

            clsSupplier Supplier = new clsSupplier();

            Boolean Found = false;

            Boolean OK = true;

            int SupplierId = 1;

            Found = Supplier.Find(SupplierId);

            if (Supplier.Email != "EddieStobart@gmail.com")

            {

                OK = false;

            }

            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestProductDescriptionFound()

        {

            clsSupplier Supplier = new clsSupplier();

            Boolean Found = false;

            Boolean OK = true;

            int SupplierId = 1;

            Found = Supplier.Find(SupplierId);

            if (Supplier.ProductDescription != "NikeTrackSuits")

            {

                OK = false;

            }

            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestQuantityFound()

        {

            clsSupplier Supplier = new clsSupplier();

            Boolean Found = false;

            Boolean OK = true;

            int SupplierId = 1;

            Found = Supplier.Find(SupplierId);

            if (Supplier.Quantity != 1)

            {

                OK = false;

            }

            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestAvailabilityFound()

        {

            clsSupplier Supplier = new clsSupplier();

            Boolean Found = false;

            Boolean OK = true;

            int SupplierId = 1;

            Found = Supplier.Find(SupplierId);

            if (Supplier.Availability != true)

            {

                OK = false;

            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAvailableFound()
        {
            clsSupplier Supplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            int SupplierId = 1;
            Found = Supplier.Find(SupplierId);
            if (Supplier.DateAvailable != Convert.ToDateTime("08/07/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier Supplier = new clsSupplier();
            string Error = "";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);

        }
        [TestMethod]
        public void NameMinLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Name = "";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Name = "a";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Name = "aa";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void NameMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMid()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void NameExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(500, 'a');
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void DateAvailableExtremeMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAvailable = TestDate.ToString();
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAvailableMinLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAvailable = TestDate.ToString();
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAvailableMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAvailable = TestDate.ToString();
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAvailableMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAvailable = TestDate.ToString();
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAvailableExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAvailable = TestDate.ToString();
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAvailableInvalidData()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string DateAvailable = "This is not a date!";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void ProductDescriptionMinLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string ProductDescription = "";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductDescriptionMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string ProductDescription = "a";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductDescriptionMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string ProductDescription = "aa";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductDescriptionMaxLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(49, 'a');
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ProductDescriptionMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string ProductDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductDescriptionMid()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(25, 'a');
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ProductDescriptionExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(500, 'a');
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Quantity = "";
            Quantity = "-2000";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Quantity = "";
            Quantity = "-1";
            //invoke the method
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            String Quantity = "";
            Quantity = "1";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Quantity = "2";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Quantity = "";
            Quantity = "2000,0000";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityInvalidData()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Quantity = "This is not a valid quantity!";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreNotEqual(Error, "");




        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Email = "";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Email = "a";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Email = "aa";
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(29,'a');
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void EmailMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Email = Email.PadRight(30, 'a');
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(15, 'a');
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void EmailExtremeMax()
        {
            clsSupplier Supplier = new clsSupplier();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(500, 'a');
            Error = Supplier.Valid(Name, Email, ProductDescription, Availability, Quantity, DateAvailable);
            Assert.AreNotEqual(Error, "");

        }
    }
}

    