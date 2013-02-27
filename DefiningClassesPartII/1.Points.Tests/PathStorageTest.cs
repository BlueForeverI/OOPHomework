using System.IO;
using _1.Points;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _1.Points.Tests
{
    
    
    /// <summary>
    ///This is a test class for PathStorageTest and is intended
    ///to contain all PathStorageTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PathStorageTest
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
        ///A test for SavePath
        ///</summary>
        [TestMethod()]
        [DeploymentItem("1.Points.dll")]
        public void SavePathTest()
        {
            Path path = new Path();
            path.Points.Add(new Point3D(1, 1, 2));
            path.Points.Add(new Point3D(4, 4, 5));

            string fileName = "file.xml";
            PathStorage.SavePath(path, fileName);

            bool fileCreated = File.Exists(fileName);
            File.Delete(fileName);

            Assert.IsTrue(fileCreated);
        }

        /// <summary>
        ///A test for LoadPath
        ///</summary>
        [TestMethod()]
        public void LoadPathTest()
        {
            Path path = new Path();
            path.Points.Add(new Point3D(1, 1, 2));
            path.Points.Add(new Point3D(4, 4, 5));

            string fileName = "file.xml";
            PathStorage.SavePath(path, fileName);

            Path deserialized = PathStorage.LoadPath(fileName);
            File.Delete(fileName);
            Assert.AreEqual(path, deserialized);
        }
    }
}
