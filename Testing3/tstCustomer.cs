using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {

        string dateCreated = DateTime.Now.Date.ToString();
        string email = "n0rix@mail.com";
        string pass = "asdfgh12";
        string name = "Chuck Norix";

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
            acc.passwrd = "asdfghjk12";
            Assert.AreEqual(tstPass, acc.passwrd);
        }

        [TestMethod]
        public void testMail()
        {
            //Create an instance of customer
            clsCustomer acc = new clsCustomer();
            //Test it
            String tstMail = "n0rix@mail.com";
            acc.email = tstMail;
            Assert.AreEqual(acc.email, tstMail);
        }

        [TestMethod]
        public void CheckAccExist()
        {
            //Create an instance of customer
            clsCustomer acc = new clsCustomer();
            // Sample data
            bool tstExist = true;
            // Just pass for now
            acc.exist = tstExist;
            //Test it
            Assert.IsTrue(acc.exist);
        }

        [TestMethod]
        public void testDate()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            DateTime testData = DateTime.Now.Date;
            //assign the data to the property
            customer.dateAdded = testData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.dateAdded, testData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer customer = new clsCustomer();
            Boolean found = false;
            Int32 id = 1;
            found = customer.Find(id);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void CustomerNotFound()
        {
            clsCustomer customer = new clsCustomer();
            bool found = false;
            bool ok = true;

            Int32 id = 1;
            found = customer.Find(id);

            if (customer.id != 1)
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
            DateTime testData = DateTime.Now.Date;
            //assign the data to the property
            customer.dateAdded = testData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.dateAdded, testData);
        }


        [TestMethod]
        public void IDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //create some test data to assign to the property
            Int32 testId = 1;
            //assign the data to the property
            customer.id = testId;
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
            customer.passwrd = testPass;
            //test to see that the two values are the same
            Assert.AreEqual(customer.passwrd, testPass);
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
            customer.exist = testExist;
            //test to see that the two values are the same
            Assert.AreEqual(customer.exist, testExist);
        }

        [TestMethod]
        public void testValidate()
        {
            clsCustomer customer = new clsCustomer();

            String error = "";

            error = customer.Validate(dateCreated, email, pass, name);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void CheckNameLenLess20()
        {
            clsCustomer customer = new clsCustomer();
            string error = "";
            string n = "";
            error = customer.Validate(dateCreated, email, pass, n);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameLenMin()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //create some test data to pass to the method
            string n = "a"; //this should be ok
            //invoke the method
            error = customer.Validate(dateCreated, email, pass, n);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameLenMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //create some test data to pass to the method
            string n = "aa"; //this should be ok
            //invoke the method
            error = customer.Validate(dateCreated, email, pass, n);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameNoLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //create some test data to pass to the method
            string n = "aaaaa"; //this should be ok
            //invoke the method
            error = customer.Validate(dateCreated, email, pass, n);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }
        [TestMethod]
        public void NameLenMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //create some test data to pass to the method
            string n = "aaaaaa"; //this should be ok
            //invoke the method
            error = customer.Validate(dateCreated, email, pass, n);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameLenNoMid()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //create some test data to pass to the method
            string n = "aaa"; //this should be ok
            //invoke the method
            error = customer.Validate(dateCreated, email, pass, n);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameLenMaxPlusOne()
        {
            clsCustomer customer = new clsCustomer();
            string error = "";
            string n = "Shpaximir Shpaxanderss";
            error = customer.Validate(dateCreated, email, pass, n);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DateAddedMinus100Y()
        {
            clsCustomer customer = new clsCustomer();
            string error = "";
            // Create the test DateTime var
            DateTime tstDate = DateTime.Now.Date;
            // Add -100 years to the tstDate value (by adding -100 years we remove 100 years from the set date)
            tstDate.AddYears(-100);
            // Create a str variable to store the tstDate value as string
            string strDate = tstDate.ToString();

            error = customer.Validate(strDate, email, pass, name);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAddedMinus1Day()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //create a variable to store the test date data
            DateTime tstDate;
            //set the date totodays date
            tstDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            tstDate = tstDate.AddDays(-1);
            //convert the date variable to a string variable
            string strDate = tstDate.ToString();
            //invoke the method
            error = customer.Validate(strDate, email, pass, name);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void CurrentDateAddedTest()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //create a variable to store the test date data
            DateTime tstDate;
            //set the date totodays date
            tstDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string strDate = tstDate.ToString();
            //invoke the method
            error = customer.Validate(strDate, email, pass, name);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void DateAddedPlus1Day()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //create a variable to store the test date data
            DateTime tstDate;
            //set the date totodays date
            tstDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            tstDate = tstDate.AddDays(1);
            //convert the date variable to a string variable
            string strDate = tstDate.ToString();
            //invoke the method
            error = customer.Validate(strDate, email, pass, name);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //create a variable to store the test date data
            DateTime tstDate;
            //set the date totodays date
            tstDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            tstDate = tstDate.AddYears(100);
            //convert the date variable to a string variable
            string strDate = tstDate.ToString();
            //invoke the method
            error = customer.Validate(strDate, email ,pass, name);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void InvalidDateAdded()
        {
            clsCustomer customer = new clsCustomer();
            string error = "";
            string tstDate = "Not a date";
            error = customer.Validate(tstDate, email, pass, name);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void EmptyMailData()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //this should fail
            string tstMail = "";
            //invoke the method
            error = customer.Validate(dateCreated, tstMail, pass, name);
            //test to see that the result is correct
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void OneCharMailData()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //this should pass
            string tstMail = "a";
            //invoke the method
            error = customer.Validate(dateCreated, tstMail, pass, name);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TwoCharMailTest()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //this should pass
            string tstMail = "aa";
            //invoke the method
            error = customer.Validate(dateCreated, tstMail, pass, name);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void MailLenLessThanMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //this should pass
            string tstMail = "m1@mail.com";
            //invoke the method
            error = customer.Validate(dateCreated, tstMail, pass, name);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void MaxMailLen()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //this should pass
            string tstMail = "shpaxandroxx@mail.com";
            //invoke the method
            error = customer.Validate(dateCreated, tstMail, pass, name);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void MailMaxLenPlus1()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string tstMail = "shpaxandroxx@mail.com";
            //invoke the method
            Error = customer.Validate(dateCreated, tstMail, pass, name);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OneCharPassData()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //this should pass
            string tstPass = "a";
            //invoke the method
            error = customer.Validate(dateCreated, email, tstPass, name);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void TwoCharPassTest()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //this should pass
            string tstPass = "aa";
            //invoke the method
            error = customer.Validate(dateCreated, email, tstPass, name);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PassLenLessThanMax()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //this should pass
            string tstMail = "password";
            //invoke the method
            error = customer.Validate(dateCreated, tstMail, pass, name);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void MaxPassLen()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String error = "";
            //this should pass
            string tstMail = "6pax@mail.bg";
            //invoke the method
            error = customer.Validate(dateCreated, tstMail, pass, name);
            //test to see that the result is correct
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PassMaxLenPlus1()
        {
            //create an instance of the class we want to create
            clsCustomer customer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string tstMail = "aaasdfghjkl1234567890";
            //invoke the method
            Error = customer.Validate(dateCreated, tstMail, pass, name);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
