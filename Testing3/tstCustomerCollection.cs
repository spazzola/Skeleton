using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace Testing3
{
    /// <summary>
    /// Summary description for tstCustomerCollection
    /// </summary>
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();

            Assert.IsNotNull(allCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();
            List<clsCustomer> tstList = new List<clsCustomer>();

            clsCustomer tstItem = new clsCustomer();

            tstItem.id = 1;
            tstItem.dateCreated = DateTime.Now.Date;
            tstItem.name = "Chuck Norix";
            tstItem.email = "n0rix@mail.com";
            tstItem.passwrd = "asdfgh12";
            tstItem.exist = true;

            tstList.Add(tstItem);

            allCustomers.customersList = tstList;

            Assert.AreEqual(allCustomers.customersList, tstList);

        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();

            int someCount = 0;

            allCustomers.count = someCount;

            Assert.AreEqual(allCustomers.count, someCount);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();

            clsCustomer tstCustomer = new clsCustomer();

            tstCustomer.id = 1;
            tstCustomer.dateCreated = DateTime.Now.Date;
            tstCustomer.name = "Chuck Norix";

            tstCustomer.email = "n0rix@mail.com";
            tstCustomer.passwrd = "asdfgh12";
            tstCustomer.exist = true;

            allCustomers.customer = tstCustomer;

            Assert.AreEqual(allCustomers.customer, tstCustomer);
        }
    }
}
