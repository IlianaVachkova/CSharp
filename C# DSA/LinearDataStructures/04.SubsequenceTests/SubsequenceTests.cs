using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SubsequenceTests
{
    [TestMethod]
    public void SubsequenceNormalTest()
        {
            var sequence = new List<int>() { 2, 3, 4, 3, 3, 2, 4, 3};
            var expected = new List<int>() { 3, 3};
            var actual = LongestSubsequence.GetLongestSubsequence(sequence);
            CollectionAssert.AreEqual(expected, actual);
        }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void SubsequenceNullTest()
    {
        List<int> sequence = null;
        var actual = LongestSubsequence.GetLongestSubsequence(sequence);
    }
}
