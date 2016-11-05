using System;
using System.Collections.Generic;
using Executor.Contracts;
using Executor.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BashSoftTesting
{
    [TestClass]
    public class OrderedDataStructureTester
    {
        private ISimpleOrderedBag<string> names;

        [TestInitialize]
        public void Setup()
        {
            this.names = new SimpleSortedList<string>();
        }

        [TestMethod]
        public void TestEmptyCtor()
        {
            this.names = new SimpleSortedList<string>();
            Assert.AreEqual(this.names.Capacity, 16);
            Assert.AreEqual(this.names.Size, 0);
        }

        [TestMethod]
        public void TestCtorWithInitialCapacity()
        {
            this.names = new SimpleSortedList<string>(20);
            Assert.AreEqual(this.names.Capacity, 20);
            Assert.AreEqual(this.names.Size, 0);
        }

        [TestMethod]
        public void TestCtorWithAllParams()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase, 30);
            Assert.AreEqual(this.names.Capacity, 30);
            Assert.AreEqual(this.names.Size, 0);
        }

        [TestMethod]
        public void TestCtorWithInitialComparer()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase);
            Assert.AreEqual(this.names.Capacity, 16);
            Assert.AreEqual(this.names.Size, 0);
        }

        [TestMethod]
        public void TestAddIncreasesSize()
        {
            this.names.Add("Nasko");
            Assert.AreEqual(1, this.names.Size);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullThrowsException()
        {
            this.names.Add(null);
        }

        [TestMethod]
        public void TestAddUnsortedDataIsHeldSorted()
        {
            this.names.Add("Rosen");
            this.names.Add("Georgi");
            this.names.Add("Balkan");

            string[] names = new[] { "Balkan", "Georgi", "Rosen" };
            int counter = 0;
            bool areSorted = true;

            foreach (var name in this.names)
            {
                if (name != names[counter])
                {
                    areSorted = false;
                    break;
                }

                counter++;
            }

            Assert.IsTrue(areSorted);
        }

        [TestMethod]
        public void TestAddingMoreThanInitialCapacity()
        {
            for (int i = 0; i < 17; i++)
            {
                this.names.Add("Pesho");
            }

            Assert.AreEqual(17, this.names.Size);
            Assert.AreNotEqual(16, this.names.Capacity);
        }

        [TestMethod]
        public void TestAddingAllFromCollectionIncreasesSize()
        {
            List<string> currentNames = new List<string>();
            currentNames.Add("Pesho");
            currentNames.Add("Gosho");

            this.names.AddAll(currentNames);

            Assert.AreEqual(2, this.names.Size);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddingAllFromNullThrowsException()
        {
            this.names.AddAll(null);
        }

        [TestMethod]
        public void TestAddAllKeepsSorted()
        {
            List<string> testNames = new List<string>()
            {
              "Nasko", "Ivan", "Simeon", "Boris", "Angel", "Stracimir"
            };

            this.names.AddAll(testNames);
            testNames.Sort();
            int counter = 0;
            bool isSorted = true;

            foreach (string name in this.names)
            {
                if (name != testNames[counter])
                {
                    isSorted = false;
                    break;
                }

                counter++;
            }

            Assert.IsTrue(isSorted);
        }

        [TestMethod]
        public void TestRemoveValidElementDecreasesSize()
        {
            this.names.Add("Stamat");
            Assert.AreEqual(1, this.names.Size);
            this.names.Remove("Stamat");
            Assert.AreEqual(0, this.names.Size);
        }

        [TestMethod]
        public void TestRemoveValidElementRemovesSelectedOne()
        {
            this.names.Add("Ivan");
            this.names.Add("Nasko");
            this.names.Remove("Ivan");

            bool isRemoved = true;
            foreach (var name in this.names)
            {
                if (name.Equals("Ivan"))
                {
                    isRemoved = false;
                    break;
                }
            }

            Assert.IsTrue(isRemoved);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestRemovingNullThrowsException()
        {
            this.names.Remove(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestJoinWithNull()
        {
            this.names.AddAll(new List<string>() { "Pesho", "Ivan", "Mihail" });
            this.names.JoinWith(null);
        }

        [TestMethod]
        public void TestJoinWorksFine()
        {
            this.names.Add("Pesho");
            this.names.Add("Ivan");
            this.names.Add("Ivan");

            string expected = "Ivan, Ivan, Pesho";
            string actual = this.names.JoinWith(", ");

            Assert.AreEqual(expected, actual);
        }
    }
}