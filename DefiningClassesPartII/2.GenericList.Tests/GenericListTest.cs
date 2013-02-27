using _2.GenericList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _2.GenericList.Tests
{
    
    
    /// <summary>
    ///This is a test class for GenericListTest and is intended
    ///to contain all GenericListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GenericListTest
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
        ///A test for Clear
        ///</summary>
        public void ClearTestHelper<T>()
        {
            GenericList<int> list = new GenericList<int>(10);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Clear();

            Assert.IsTrue(list.Count == 0);
        }

        [TestMethod()]
        public void ClearTest()
        {
            ClearTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ExpandList
        ///</summary>
        public void ExpandListTestHelper<T>()
        {
            GenericList<int> list = new GenericList<int>(3);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            Assert.IsTrue(list.Capacity == 6);
        }

        [TestMethod()]
        [DeploymentItem("2.GenericList.dll")]
        public void ExpandListTest()
        {
            ExpandListTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Min
        ///</summary>
        public void MinTestHelper<T>()
            where T : IComparable
        {
            GenericList<int> list = new GenericList<int>(5);
            list.Add(12);
            list.Add(31);
            list.Add(14);
            list.Add(5);
            list.Add(7);

            Assert.IsTrue(list.Min() == 5);
        }

        [TestMethod()]
        public void MinTest()
        {
            MinTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Max
        ///</summary>
        public void MaxTestHelper<T>()
            where T : IComparable
        {
            GenericList<int> list = new GenericList<int>(5);
            list.Add(12);
            list.Add(31);
            list.Add(14);
            list.Add(5);
            list.Add(7);

            Assert.IsTrue(list.Max() == 31);
        }

        [TestMethod()]
        public void MaxTest()
        {
            MaxTestHelper<GenericParameterHelper>();
        }
    }
}
