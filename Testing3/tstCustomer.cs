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
            DateTime testData = DateTime.Now.Date;
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
            Int32 id = 0;
            found = customer.Find(id);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void CustomerNotFound()
        {
            clsCustomer customer = new clsCustomer();
            bool found = false;
            bool ok = true;

            Int32 id = 3401;
            found = customer.Find(id);

            if (customer.id != 3401)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            customer.dateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Ancustomer.dateAdded, TestData);
        }


        [TestMethod]
        public void IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            Int32 testId = 1;
            //assign the data to the property
            customer.id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.id, testId);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            string testName = "Shpaximirr Maxan";
            //assign the data to the property
            customer.name = testName;
            //test to see that the two values are the same
            Assert.AreEqual(customer.name, testName);
        }

        [TestMethod]
        public void PassPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            string testPass = "asdfgh12";
            //assign the data to the property
            customer.pass = testPass;
            //test to see that the two values are the same
            Assert.AreEqual(customer.pass, testPass);
        }

        [TestMethod]
        public void emailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            string testMail = "shpaximir@mail.com";
            //assign the data to the property
            customer.email = testMail;
            //test to see that the two values are the same
            Assert.AreEqual(customer.email, testMail);
        }

        [TestMethod]
        public void existsPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            bool testExist = true;
            //assign the data to the property
            customer.exists = testExist;
            //test to see that the two values are the same
            Assert.AreEqual(customer.exists);
        }
    }
}
