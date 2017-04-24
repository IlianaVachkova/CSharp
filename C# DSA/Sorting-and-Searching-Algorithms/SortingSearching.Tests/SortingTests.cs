using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingSearching.Tests
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuickSortNullTest()
        {
            IList<int> arr = null;
            Quicksorter<int> sorter = new Quicksorter<int>();
            sorter.Sort(arr);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void QuickSortZeroTest()
        {
            IList<int> arr = new List<int>();
            Quicksorter<int> sorter = new Quicksorter<int>();
            sorter.Sort(arr);
        }

        [TestMethod]
        public void QuickSortNormalTest()
        {
            var arr = new List<int>() { 22, 11, 101, 33, 0, 101 };
            Quicksorter<int> sorter = new Quicksorter<int>();
            sorter.Sort(arr);
            var expected = new List<int>() { 0, 11, 22, 33, 101, 101 };
            CollectionAssert.AreEqual(arr, expected);
        }

        [TestMethod]
        public void QuickSortSortedTest()
        {
            var arr = new List<int>() { 0, 11, 22, 33, 101, 101 };
            Quicksorter<int> sorter = new Quicksorter<int>();
            sorter.Sort(arr);
            var expected = new List<int>() { 0, 11, 22, 33, 101, 101 };
            CollectionAssert.AreEqual(arr, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MergeSortNullTest()
        {
            IList<int> arr = null;
            MergeSorter<int> sorter = new MergeSorter<int>();
            sorter.Sort(arr);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MergeSortZeroTest()
        {
            IList<int> arr = new List<int>();
            MergeSorter<int> sorter = new MergeSorter<int>();
            sorter.Sort(arr);
        }

        [TestMethod]
        public void MergeSortNormalTest()
        {
            var arr = new List<int>() { 22, 11, 101, 33, 0, 101 };
            MergeSorter<int> sorter = new MergeSorter<int>();
            sorter.Sort(arr);
            var expected = new List<int>() { 0, 11, 22, 33, 101, 101 };
            CollectionAssert.AreEqual(arr, expected);
        }

        [TestMethod]
        public void MergeSortSortedTest()
        {
            var arr = new List<int>() { 0, 11, 22, 33, 101, 101 };
            MergeSorter<int> sorter = new MergeSorter<int>();
            sorter.Sort(arr);
            var expected = new List<int>() { 0, 11, 22, 33, 101, 101 };
            CollectionAssert.AreEqual(arr, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SelectionSortNullTest()
        {
            IList<int> arr = null;
            SelectionSorter<int> sorter = new SelectionSorter<int>();
            sorter.Sort(arr);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SelectionSortZeroTest()
        {
            IList<int> arr = new List<int>();
            SelectionSorter<int> sorter = new SelectionSorter<int>();
            sorter.Sort(arr);
        }

        [TestMethod]
        public void SelectionSortNormalTest()
        {
            var arr = new List<int>() { 22, 11, 101, 33, 0, 101 };
            SelectionSorter<int> sorter = new SelectionSorter<int>();
            sorter.Sort(arr);
            var expected = new List<int>() { 0, 11, 22, 33, 101, 101 };
            CollectionAssert.AreEqual(arr, expected);
        }

        [TestMethod]
        public void SelectionSortSortedTest()
        {
            var arr = new List<int>() { 0, 11, 22, 33, 101, 101 };
            SelectionSorter<int> sorter = new SelectionSorter<int>();
            sorter.Sort(arr);
            var expected = new List<int>() { 0, 11, 22, 33, 101, 101 };
            CollectionAssert.AreEqual(arr, expected);
        }
    }
}