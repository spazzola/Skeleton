using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing6
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();


            Assert.IsNotNull(AllSupplier);
        }
        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierId = 1;
            TestItem.Name = "Whole Sale";
            TestItem.Email = "wholesale@gmail.com";
            TestItem.ProductDescription = "Jack Shirts";
            TestItem.Quantity = 20;
            TestItem.Availability = true;
            TestItem.DateAvailable = Convert.ToDateTime("08/09/2022");
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;

            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }
        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            TestSupplier.SupplierId = 1;
            TestSupplier.Name = "EddieStobart";
            TestSupplier.Email = "EddieStobart@gmail.com";
            TestSupplier.ProductDescription = "NikeTrackSuits";
            TestSupplier.Quantity = 1;
            TestSupplier.Availability = true;
            TestSupplier.DateAvailable = System.DateTime.Now.Date;
            AllSuppliers.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
            
        }
        [TestMethod]
        public void ListAndCountPropertyOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();
            TestItem.SupplierId = 1;
            TestItem.Name = "Whole Sale";
            TestItem.Email = "Wsale@gmail.com";
            TestItem.ProductDescription = "Jack Shirts";
            TestItem.Quantity = 20;
            TestItem.Availability = true;
            TestItem.DateAvailable = Convert.ToDateTime("08/09/2022");
            TestList.Add(TestItem);
            AllSuppliers.SupplierList = TestList;
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.SupplierId = 31;
            TestItem.Name = "doesntexist";
            TestItem.Email = "doesntexist@gmail.com";
            TestItem.ProductDescription = "doesntexist";
            TestItem.Quantity = 200;
            TestItem.Availability = true;
            TestItem.DateAvailable = DateTime.Now.Date;
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierId = PrimaryKey;
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.Name = "EddieStobart";
            TestItem.Email = " EddieStobart@gmail.com";
            TestItem.ProductDescription = "NikeTrackSuits";
            TestItem.Quantity = 1;
            TestItem.Availability = true;
            TestItem.DateAvailable = DateTime.Now.Date;
           
            AllSuppliers.ThisSupplier = TestItem;
            PrimaryKey = AllSuppliers.Add();
            TestItem.SupplierId = PrimaryKey;
            TestItem.Name = "CarwoCamuud";
            TestItem.Email = "CarwoCamuud@gmail.com";
            TestItem.ProductDescription = "ShortsleevesCamuud";
            TestItem.Quantity = 1;
            TestItem.Availability = false;
            TestItem.DateAvailable = DateTime.Now.Date;
            AllSuppliers.ThisSupplier = TestItem;
            AllSuppliers.Update();
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestItem = new clsSupplier();
            Int32 PrimaryKey = 0;
            TestItem.Name = " some name";
            TestItem.Email = " SomeEmail@gmail.com";
            TestItem.ProductDescription = "SomeThing";
            TestItem.Quantity = 40;
            TestItem.Availability = true;
            TestItem.DateAvailable = DateTime.Now.Date;
            AllSupplier.ThisSupplier = TestItem;
            PrimaryKey = AllSupplier.Add();
            TestItem.SupplierId = PrimaryKey;
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            AllSupplier.Delete();
            Boolean Found = AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsSupplierCollection Allsuppliers = new clsSupplierCollection();
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportByName("");
            Assert.AreEqual(Allsuppliers.Count, FilteredSuppliers.Count);
        }
        [TestMethod]
        public void ReportByNameNoneFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportByName("xxxx");
            Assert.AreEqual(0, FilteredSuppliers.Count);

        }
        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            Boolean OK = true;
            FilteredSuppliers.ReportByName("noname");
            if (FilteredSuppliers.Count == 2)
            {
                if (FilteredSuppliers.SupplierList[0].SupplierId != 36)
                {
                    OK = false;
                }
                if (FilteredSuppliers.SupplierList[1].SupplierId != 37)
                {
                    OK = false;
                }
            }
            else
            { 
                OK = false;
            }
                Assert.IsTrue(OK);
            }
        }
    }

