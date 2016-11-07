using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestSchool
{
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void AddStudentTest()
        {
            var school = new School("Telerik Academy");
            var pesho = new Student("Pesho", 10000);

            school.AddStudent(pesho);
            var expected = new List<Student> { pesho };
            var actual = school.Students;

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void DeleteStudentTest()
        {
            var school = new School("Telerik Academy");
            var pesho = new Student("Pesho", 10000);
            var gosho = new Student("Gosho", 10100);

            school.AddStudent(pesho);
            school.AddStudent(gosho);
            school.RemoveStudent(pesho);
            var expected = new List<Student> { gosho };
            var actual = school.Students;

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void AddCourseTest()
        {
            var school = new School("Telerik Academy");
            var course = new Course("KPK");

            school.AddCourse(course);
            var actual = school.Courses;
            var expected = new List<Course> { course };

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void DeleteCourseTest()
        {
            var school = new School("Telerik Academy");
            var kpk = new Course("KPK");
            var js = new Course("JS");

            school.AddCourse(kpk);
            school.AddCourse(js);
            school.RemoveCourse(kpk);
            var actual = school.Courses;
            var expected = new List<Course> { js };

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void ToStringTest()
        {
            var school = new School("Telerik Academy");
            var kpk = new Course("KPK");
            var js = new Course("JS");

            school.AddCourse(kpk);
            school.AddCourse(js);
            var pesho = new Student("Pesho", 10000);
            var gosho = new Student("Gosho", 10100);
            school.AddStudent(pesho);
            school.AddStudent(gosho);
            var actual = school.ToString();
            var expected =
                "School: Telerik Academy\r\nStudents: Student: Pesho, Number: 10000; Student: Gosho, Number: 10100\r\nCourses: Course: KPK; Course: JS\r\n";

            Assert.AreEqual(expected, actual);
        }
    }
}