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
        public void IdPropertyOk()

        {
            clsSupplier Supplier = new clsSupplier();
            int TestData = 1;
            Supplier.Id = TestData;
            Assert.AreEqual(Supplier.Id, TestData);
       
        }
        [TestMethod]
        public void NamePropertyOK()
        {
            string TestData = "Harry";
            clsSupplier.Name = TestData;
            Assert.AreEqual(clsSupplier.Name, TestData);
        }
        [TestMethod]
        public void EmailPropertyOk()
        {
            String TestData = "Harry@gmail.com";
            clsSupplier.Email = TestData;
            Assert.AreEqual(clsSupplier.Email, TestData);
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
            Int32 TestData = 1;
            Supplier.Quantity = TestData;
            Assert.AreEqual(Supplier.Quantity, TestData);

        }
    }
}
