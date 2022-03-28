using ClassLibrary;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace Testing6

{

    [TestClass]

    public class tstSupplier

    {

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

            string TestData = "Harry";

            Supplier.Name = TestData;

            Assert.AreEqual(Supplier.Name, TestData);

        }

        [TestMethod]

        public void EmailPropertyOk()

        {

            clsSupplier Supplier = new clsSupplier();

            String TestData = "Harry@gmail.com";

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

            String TestData = "Shirts";

            Supplier.ProductDescription = TestData;

            Assert.AreEqual(Supplier.ProductDescription, TestData);

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

        public void TestSupplierIdFound()

        {

            clsSupplier Supplier = new clsSupplier();

            Boolean Found = false;

            Boolean Ok = true;

            int SupplierId = 1;

            Found = Supplier.Find(SupplierId);

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

            if (Supplier.Name != "Harry")

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

            if (Supplier.Email != "Harry@gmail.com")

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

            if (Supplier.ProductDescription != "Shirt")

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

    }

}