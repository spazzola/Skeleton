using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void checkIfClassclsStaffExists()
        {
            clsStaff staff = new clsStaff();
            Assert.IsNotNull(staff);
        }
    }
}
