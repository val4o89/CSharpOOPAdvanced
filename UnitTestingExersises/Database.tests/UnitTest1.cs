using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P01Database;

namespace Databasee.tests
{
    [TestClass]
    public class UnitTest1
    {
        Database database;
        [TestInitialize]
        public void TestInitialize()
        {
            database = new Database();
        }

        [TestMethod]
        public void TestDatabaseSize()
        {
            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }
            Assert.AreEqual(16, database.Count, $"Database size is {database.Count}");
        }

        [TestMethod]
        public void TestAddTwoElements()
        {
            database.Add(21);
            database.Add(45);
            Assert.AreEqual(2, database.Count, $"Database size is {database.Count}");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestByAddingOverThanSixteenElements()
        {
            for (int i = 0; i < 18; i++)
            {
                database.Add(i);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestRemoveElementWhenTheCountOfDatabaseIsZero()
        {
            database.Remove();
        }

        [TestMethod]
        public void TestConstructorToAddSixteenElements()
        {
            database = new Database(new int[16]);
            Assert.AreEqual(16, database.Count);
        }

        [TestMethod]
        public void TestFetchMethodIfReturnTheCorrectCollection()
        {
            int[] expectedCollection = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            for (int i = 1; i <= 16; i++)
            {
                database.Add(i);
            }
            int[] fetchedCollection = database.Fetch();

            CollectionAssert.AreEqual(expectedCollection, fetchedCollection);
            
        }
    }

}
