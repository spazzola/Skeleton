using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstAccount
    {
        [TestMethod]
        public void TestAccountExists()
        {
            //Create a new account
            clsAccount acc = new clsAccount();
            //Check thatthe value acc holds is != null
            Assert.IsNotNull(acc);
        }
    }
}
