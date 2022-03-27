using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1 {

    [TestClass]
    public class tstStaff {

        string fullName = "Jack Smith";
        string login = "jack22";
        string password = "smith55";
        string lastLogged = DateTime.Now.Date.ToString();
        string salary = 1000.35.ToString();

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

            if (staff.staffId != 1)
            {
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

            if (staff.fullName != "Jack Smith")
            {
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

            if (staff.salary != 10.0)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testStaffLoginFound() {
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
        public void testStaffPasswordFound() {
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
        public void testStaffLastLoggedFound() {
            clsStaff staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 staffId = 1;
            found = staff.Find(staffId);

            if (staff.lastLogged != Convert.ToDateTime("01/01/2022"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }



        /*
         * FULLNAME TESTS
         */
        [TestMethod]
        public void FullNameMinLessOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string fullName = "";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void FullNameMin() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string fullName = "a";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FullNameMinPLusOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string fullName = "aa";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string fullName = "aaaaaaaaaaaaaaaaaaa";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FullNameMax() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string fullName = "aaaaaaaaaaaaaaaaaaaa";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FullNameMid() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string fullName = "aaaaaaaaaa";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string fullName = "aaaaaaaaaaaaaaaaaaaaa";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void FullNameExtremeMax() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            fullName = fullName.PadRight(1000, 'a');
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreNotEqual(error, "");
        }



        /*
         * LOGIN TESTS
         */
        [TestMethod]
        public void LoginMinLessOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string login = "";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void LoginMin() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string login = "a";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LoginMinPLusOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string login = "aa";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LoginMaxLessOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string login = "aaaaaaaaaaaaaaaaaaa";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LoginMax() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string login = "aaaaaaaaaaaaaaaaaaaa";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LoginMid() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string login = "aaaaaaaaaa";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LoginMaxPlusOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string login = "aaaaaaaaaaaaaaaaaaaaa";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void LoginExtremeMax() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            login = login.PadRight(1000, 'a');
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreNotEqual(error, "");
        }



        /*
         * PASSWORD TESTS
         */
        [TestMethod]
        public void PasswordMinLessOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string password = "";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PasswordMin() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string password = "a";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordMinPLusOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string password = "aa";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string password = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordMax() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string password = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordMid() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string password = "aaaaaaaaaaaaaaa";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string password = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            login = password.PadRight(1000, 'a');
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreNotEqual(error, "");
        }



        /*
         * LAST LOGGED TESTS
         */
        [TestMethod]
        public void LastLoggedExtremeMin() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(-100);
            string lastLogged = testDate.ToString();

            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");

        }

        [TestMethod]
        public void LastLoggedMaxLessOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddSeconds(-1);
            string lastLogged = testDate.ToString();

            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LastLoggedMax() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            DateTime testDate;
            testDate = DateTime.Now.Date;
            string lastLogged = testDate.ToString();

            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void LastLoggedMaxPlusOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddSeconds(1);
            string lastLogged = testDate.ToString();

            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void LastLoggedExtremeMax() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            DateTime testDate;
            testDate = DateTime.Now.Date;
            testDate = testDate.AddYears(100);
            string lastLogged = testDate.ToString();

            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void LastLoggedInvalidData() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string lastLogged = "some string";
            error = staffMember.Valid(fullName, login, password, lastLogged, salary);

            Assert.AreNotEqual(error, "");
        }



        /*
         * SALARY TESTS
         */
        [TestMethod]
        public void SalaryExtremeMin() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string stringSalary = (-10000000.00).ToString();
            error = staffMember.Valid(fullName, login, password, lastLogged, stringSalary);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void SalaryMinLessOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string stringSalary = (-0.01).ToString();
            error = staffMember.Valid(fullName, login, password, lastLogged, stringSalary);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void SalaryMin() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string stringSalary = 0.0.ToString();
            error = staffMember.Valid(fullName, login, password, lastLogged, stringSalary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SalaryMinPlusOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string stringSalary = 0.1.ToString();
            error = staffMember.Valid(fullName, login, password, lastLogged, stringSalary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SalaryMaxLessOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string stringSalary = 999999.99.ToString();
            error = staffMember.Valid(fullName, login, password, lastLogged, stringSalary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SalaryMax() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string stringSalary = 1000000.00.ToString();
            error = staffMember.Valid(fullName, login, password, lastLogged, stringSalary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SalaryMaxPlusOne() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string stringSalary = 1000000.01.ToString();
            error = staffMember.Valid(fullName, login, password, lastLogged, stringSalary);

            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void SalaryMid() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string stringSalary = 500000.00.ToString();
            error = staffMember.Valid(fullName, login, password, lastLogged, stringSalary);

            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SalaryInvalidData() {
            clsStaff staffMember = new clsStaff();
            String error = "";

            string stringSalary = "some string";
            error = staffMember.Valid(fullName, login, password, lastLogged, stringSalary);

            Assert.AreNotEqual(error, "");
        }
    }
}
