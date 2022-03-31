using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1 {
    [TestClass]
    public class tstStaffCollection {

        [TestMethod]
        public void InstanceOK() {
            clsStaffCollection allStaff = new clsStaffCollection();
            Assert.IsNotNull(allStaff);
        }

        [TestMethod]
        public void StaffListOK() {
            clsStaffCollection allStaff = new clsStaffCollection();
            List<clsStaff> testList = new List<clsStaff>();
            
            clsStaff testStaff = new clsStaff();
            testStaff.staffId = 1;
            testStaff.fullName = "Jack Smith";
            testStaff.login = "jack";
            testStaff.password = "smith55";
            testStaff.salary = 1000.00;
            testStaff.isAdmin = true;
            testStaff.lastLogged = Convert.ToDateTime("13/02/2020 13:00");

            testList.Add(testStaff);
            allStaff.staffList = testList;

            Assert.AreEqual(allStaff.staffList, testList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK() {
            clsStaffCollection allStaff = new clsStaffCollection();
            
            clsStaff testStaff = new clsStaff();
            testStaff.staffId = 1;
            testStaff.fullName = "Jack Smith";
            testStaff.login = "jack";
            testStaff.password = "smith55";
            testStaff.salary = 1000.00;
            testStaff.isAdmin = true;
            testStaff.lastLogged = Convert.ToDateTime("13/02/2020 13:00");

            allStaff.thisStaff = testStaff;

            Assert.AreEqual(allStaff.thisStaff, testStaff);
        }

        [TestMethod]
        public void ListAndCountOK() {
            clsStaffCollection allStaff = new clsStaffCollection();
            List<clsStaff> testList = new List<clsStaff>();
            
            clsStaff testStaff = new clsStaff();
            testStaff.staffId = 1;
            testStaff.fullName = "Jack Smith";
            testStaff.login = "jack";
            testStaff.password = "smith55";
            testStaff.salary = 1000.00;
            testStaff.isAdmin = true;
            testStaff.lastLogged = Convert.ToDateTime("13/02/2020 13:00");

            testList.Add(testStaff);
            allStaff.staffList = testList;

            Assert.AreEqual(allStaff.count, testList.Count);
        }

        [TestMethod]
        public void AddMethodOK() {
            clsStaffCollection allStaff = new clsStaffCollection();

            clsStaff testItem = new clsStaff();
            Int32 primaryKey = 0;
            testItem.fullName = "Ron";
            testItem.login = "ron11";
            testItem.password = "ron22";
            testItem.salary = 1000.00;
            testItem.isAdmin = true;
            testItem.lastLogged = Convert.ToDateTime("13/02/2020 13:00");

            allStaff.thisStaff = testItem;
            primaryKey = allStaff.Add();
            testItem.staffId = primaryKey;

            allStaff.thisStaff.Find(primaryKey);

            Assert.AreEqual(allStaff.thisStaff, testItem);
        }

        [TestMethod]
        public void UpdateMethodOK() {
            clsStaffCollection allStaff = new clsStaffCollection();

            clsStaff testItem = new clsStaff();
            Int32 primaryKey = 0;
            testItem.fullName = "Ron";
            testItem.login = "ron11";
            testItem.password = "ron22";
            testItem.salary = 1000.00;
            testItem.isAdmin = true;
            testItem.lastLogged = Convert.ToDateTime("13/02/2020 13:00");

            allStaff.thisStaff = testItem;
            primaryKey = allStaff.Add();
            testItem.staffId = primaryKey;

            testItem.fullName = "Elon";
            testItem.login = "elon1";
            testItem.password = "lon22";
            testItem.salary = 1.00;
            testItem.isAdmin = false;
            testItem.lastLogged = Convert.ToDateTime("01/01/2000 10:00");

            allStaff.Update();
            allStaff.thisStaff.Find(primaryKey);
            Assert.AreEqual(allStaff.thisStaff, testItem);
        }

        [TestMethod]
        public void DeleteMethodOK() {
            clsStaffCollection allStaff = new clsStaffCollection();

            clsStaff testItem = new clsStaff();
            Int32 primaryKey = 0;
            testItem.fullName = "Ron";
            testItem.login = "ron11";
            testItem.password = "ron22";
            testItem.salary = 1000.00;
            testItem.isAdmin = true;
            testItem.lastLogged = Convert.ToDateTime("13/02/2020 13:00");

            allStaff.thisStaff = testItem;
            primaryKey = allStaff.Add();
            testItem.staffId = primaryKey;

            allStaff.thisStaff.Find(primaryKey);
            allStaff.Delete();

            Boolean found = allStaff.thisStaff.Find(primaryKey);

            Assert.IsFalse(found);
        }
    }
}
