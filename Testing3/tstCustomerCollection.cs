using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing3
{
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection customerCollection = new clsCustomerCollection();

            Assert.IsNotNull(customerCollection);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection customerCollection = new clsCustomerCollection();
            List<clsCustomer> tstList = new List<clsCustomer>();

            clsCustomer tstItem = new clsCustomer();

            tstItem.id = 1;
            tstItem.dateCreated = DateTime.Now.Date;
            tstItem.name = "Chuck Norix";
            tstItem.email = "n0rix@mail.com";
            tstItem.passwrd = "asdfgh12";
            tstItem.exist = true;

            tstList.Add(tstItem);

            customerCollection.customersList = tstList;

            Assert.AreEqual(customerCollection.customersList, tstList);

        }
    }
}
