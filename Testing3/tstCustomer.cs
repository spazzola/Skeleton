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
            //create an instance of the class we want to create
            clsCustomer acc = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(acc);
        }

        [TestMethod]
        public void CheckIDVal()
        {

            clsCustomer acc = new clsCustomer();
            Assert.AreNotEqual(acc.id, null);
        }

        [TestMethod]
        public void TestName()
        {
            //Create an instance of a customer
            clsCustomer acc = new clsCustomer();
            //Test it
            String n = "Chuck Norix";
            acc.name = n;
            Assert.AreEqual(n, acc.name);
        }

        [TestMethod]
        public void testLogin()
        {
            //Create an instance of customer
            clsCustomer acc = new clsCustomer();
            //Test it
            String tstPass = "asdfghjk12";
            acc.pass = "asdfghjk12";
            Assert.AreEqual(tstPass, acc.pass);
        }

        [TestMethod]
        public void testMail()
        {
            //Create an instance of customer
            clsCustomer acc = new clsCustomer();
            //Test it
            String tstMail = "cnorix22@zmail.org";
            acc.email = tstMail;
            Assert.AreEqual(acc.email, tstMail);
        }

        [TestMethod]
        public void CheckAccExist()
        {
            //Create an instance of customer
            clsCustomer acc = new clsCustomer();
            //Test it
            Assert.IsTrue(acc.exists);
        }

        [TestMethod]
        public void testDate()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            customer.dateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.dateAdded, TestData);
        }
        [TestMethod]

        public void FindMethodOK()
        {
            clsCustomer customer = new clsCustomer();
            Boolean found = false;
            Int32 id = 2132;
            found = customer.Find(id);
            Assert.IsTrue(found);
        }
    }
}
