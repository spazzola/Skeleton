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
            Assert.AreEqual(Supplier.Id, TestData);
       
        }
        [TestMethod]
        public void NamePropertyOK()
        {
            clsSupplier Supplier clsSupplier
            string TestData = "Harry";
            Supplier.Name = TestData;
            Assert.AreEqual(Supplier.Name, TestData);
        }
        [TestMethod]
        public void EmailPropertyOk()
        {
            clsSupplier Supplier = new clsSupplier();
            string TestData = "Harry@gmail.com";
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
            string TestData = "Shirts";
            Assert.AreEqual(Supplier.ProductDescription, TestData);
        }
    }
}
