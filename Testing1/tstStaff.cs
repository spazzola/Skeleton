using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1 {
    [TestClass]
    public class tstStaff {
        [TestMethod]
        public void checkIfClassclsStaffExists() {
            clsStaff staff = new clsStaff();
            Assert.IsNotNull(staff);
        }

        [TestMethod]
        public void checkIfPropertyIdExists() {
            clsStaff staff = new clsStaff();
            int staffId = 1;
            staff.staffId = staffId;
            Assert.AreEqual(staff.staffId, staffId);
        }

        [TestMethod]
        public void checkIfPropertyFullNameExists() {
            clsStaff staff = new clsStaff();
            String fullName = "John Martinez";
            staff.fullName = fullName;
            Assert.AreEqual(staff.fullName, fullName);
        }

        [TestMethod]
        public void checkIfPropertySalaryExists() {
            clsStaff staff = new clsStaff();
            Double salary = 1000.0;
            staff.salary = salary;
            Assert.AreEqual(staff.salary, salary);
        }

        [TestMethod]
        public void checkIfPropertyLoginExists() {
            clsStaff staff = new clsStaff();
            String login = "john65";
            staff.login = login;
            Assert.AreEqual(staff.login, login);
        }

        [TestMethod]
        public void checkIfPropertyPasswordExists() {
            clsStaff staff = new clsStaff();
            String password = "vxbcjs2";
            staff.password = password;
            Assert.AreEqual(staff.password, password);
        }

        [TestMethod]
        public void checkIfPropertyIsAdminExists() {
            clsStaff staff = new clsStaff();
            Boolean isAdmin = true;
            staff.isAdmin = isAdmin;
            Assert.AreEqual(staff.isAdmin, isAdmin);
        }

        [TestMethod]
        public void checkIfPropertyLastLoggedExists() {
            clsStaff staff = new clsStaff();
            DateTime lastLogged = DateTime.Now.Date;
            staff.lastLogged = lastLogged;
            Assert.AreEqual(staff.lastLogged, lastLogged);
        }

        [TestMethod]
        public void checkIfFindMethodReturnsTrue() {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Int32 staffId = 1;
            found = staff.Find(staffId);

            Assert.IsTrue(found);
        }

        [TestMethod]
        public void testStaffIdNoFound() {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 staffId = 1;
            found = staff.Find(staffId);

            if (staff.staffId != 1) {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testStaffFullNameFound() {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 staffId = 1;
            found = staff.Find(staffId);

            if (staff.fullName != "Jack Smith") {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testStaffSalaryFound() {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 staffId = 1;
            found = staff.Find(staffId);

            if (staff.salary != 10.0) {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testStaffLoginFound()
        {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 staffId = 1;
            found = staff.Find(staffId);

            if (staff.login != "jack00")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testStaffPasswordFound()
        {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 staffId = 1;
            found = staff.Find(staffId);

            if (staff.password != "smith25")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testStaffLastLoggedFound()
        {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 staffId = 1;
            found = staff.Find(staffId);

            if (staff.lastLogged != Convert.ToDateTime("01/01/2022")) {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

    }
}
