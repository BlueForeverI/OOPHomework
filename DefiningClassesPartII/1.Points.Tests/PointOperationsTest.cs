﻿using _1.Points;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _1.Points.Tests
{
    
    
    /// <summary>
    ///This is a test class for PointOperationsTest and is intended
    ///to contain all PointOperationsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PointOperationsTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for CalculateDistanceBetweenPoints
        ///</summary>
        [TestMethod()]
        public void CalculateDistanceBetweenPointsTest()
        {
            Point3D a = new Point3D(1, 2, 3);
            Point3D b = new Point3D(4, 5, 6);

            double expected = Math.Sqrt(27); 
            double actual = PointOperations.CalculateDistanceBetweenPoints(a, b);
            
            Assert.AreEqual(expected, actual);
        }
    }
}
