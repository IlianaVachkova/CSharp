using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingSearching.Tests
{
    [TestClass]
    public class SearchingTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LinearSearchNullTest()
        {
            var collection = new SortableCollection<string>(new[] { "da", "ne" });
            string word = null;
            collection.LinearSearch(word);
        }

        [TestMethod]
        public void LinearSearchNotFoundTest()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            var actual = collection.LinearSearch(5);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void LinearSearchFoundTest()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            var actual = collection.LinearSearch(33);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void LinearSearchFoundPositionAtEndTest()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            var actual = collection.LinearSearch(22);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BinarySearchNullTest()
        {
            var collection = new SortableCollection<string>(new[] { "da", "ne" });
            string word = null;
            collection.BinarySearch(word);
        }

        [TestMethod]
        public void BinarySearchNotFoundTest()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            var actual = collection.BinarySearch(5);
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void BinarySearchFoundTest()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            var actual = collection.BinarySearch(33);
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void BinarySearchFoundPositionAtEndTest()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            var actual = collection.BinarySearch(22);
            Assert.AreEqual(true, actual);
        }
    }
}
