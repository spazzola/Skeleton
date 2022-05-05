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

            int someCount = 2;

            allCustomers.count = someCount;

            Assert.AreEqual(allCustomers.count, someCount);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();

            clsCustomer tstItem = new clsCustomer();

            tstItem.id = 1;
            tstItem.dateCreated = DateTime.Now.Date;
            tstItem.name = "Chuck Norix";

            tstItem.email = "n0rix@mail.com";
            tstItem.passwrd = "asdfgh12";
            tstItem.exist = true;

            allCustomers.thisCustomer = tstItem;

            Assert.AreEqual(allCustomers.thisCustomer, tstItem);
        }

        [TestMethod]
        public void ListAndCountOK()
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

            Assert.AreEqual(allCustomers.count, tstList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();

            Assert.AreEqual(allCustomers.count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection allCustomers = new clsCustomerCollection();

            clsCustomer tstItem = new clsCustomer();

            Int32 pk = 0;

            tstItem.id = 2;
            tstItem.dateCreated = DateTime.Now.Date;
            tstItem.name = "6pax Shpaxanders";
            tstItem.email = "6pax@mail.com";
            tstItem.passwrd = "qwerty_2000s";
            tstItem.exist = true;

            allCustomers.thisCustomer = tstItem;

            pk = allCustomers.Add();

            tstItem.id = pk;

            allCustomers.thisCustomer.Find(pk);

            Assert.AreEqual(allCustomers.thisCustomer, tstItem);
        }
    }
}
