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
    }
}
