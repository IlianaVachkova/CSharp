using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSchool
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            var student = new Student("Pesho", 10000);

            var actual = student.ToString();
            var expected = "Student: Pesho, Number: 10000";

            Assert.AreEqual(expected, actual);
        }
    }
}
