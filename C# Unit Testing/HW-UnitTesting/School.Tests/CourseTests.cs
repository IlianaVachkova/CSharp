using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestSchool
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void AddStudentTest()
        {
            var kpk = new Course("KPK");
            var pesho = new Student("Pesho", 10000);
            var gosho = new Student("Gosho", 10100);

            kpk.AddStudent(pesho);
            kpk.AddStudent(gosho);
            var expected = new List<Student> { pesho, gosho };
            var actual = kpk.Students;

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void AddStudentOverThirtyTest()
        {
            var kpk = new Course("KPK");
            var pesho = new Student("Pesho", 10000);
            for (int i = 0; i < 30; i++)
            {
                kpk.AddStudent(pesho);
            }

            var gosho = new Student("Gosho", 10100);
            kpk.AddStudent(gosho);
            var actual = kpk.Students;

            var expected = new List<Student>(30);
            for (int i = 0; i < 30; i++)
            {
                expected.Add(pesho);
            }

            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void DeleteStudentTest()
        {
            var kpk = new Course("KPK");
            var pesho = new Student("Pesho", 10000);
            var gosho = new Student("Gosho", 10100);

            kpk.AddStudent(pesho);
            kpk.AddStudent(gosho);
            kpk.RemoveStudent(pesho);

            var expected = new List<Student> { gosho };
            var actual = kpk.Students;

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void ToStringTest()
        {
            var kpk = new Course("KPK");
            var pesho = new Student("Pesho", 10000);
            var gosho = new Student("Gosho", 10100);

            kpk.AddStudent(pesho);
            kpk.AddStudent(gosho);

            var actual = kpk.ToString();
            var expected = "Course: KPK\r\nStudents: Student: Pesho, Number: 10000; Student: Gosho, Number: 10100";
            Assert.AreEqual(expected, actual);
        }
    }
}
