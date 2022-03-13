using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing3
{
	[TestClass]
	public class PropertyExists
	{
		[TestMethod]
		public void CheckAcctExists()
		{
			Account acc = new Account();
			Boolean test_data = true;

			acc.AccExists = test_data;

			Assert.AreEqual(acc.AccExists, test_data);
		}

		public void CheckInstanceOK()
        {
			Account acc = new Account();
			Assert.IsNotNull(acc);
        }
	}
}