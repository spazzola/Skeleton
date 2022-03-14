using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer acc = new clsCustomer();
            Assert.IsNotNull(acc);
        }

        [TestMethod]
        public void IDNotNull()
        {
            clsCustomer acc = new clsCustomer();
            Assert.AreNotEqual(acc.id, null);
        }

    }
}
