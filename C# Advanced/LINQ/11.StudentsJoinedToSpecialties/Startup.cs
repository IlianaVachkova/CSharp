/*
    Create a new class StudentSpecialty that holds specialty name and faculty number. 
    Create a Student class that holds student name and  faculty number. Create a list 
    of student specialties, where each specialty corresponds to a certain student (via 
    the faculty number). Print all student names alphabetically along with their faculty 
    number and specialty name. Use the "join" LINQ operator. 

    You will recieve several specialties in format :
        {specialty name} {faculty number}
    Until you reach "Students:" , you should add specialties to the collection. After you 
    reach "Students:", you should start reading students in format :
        {faculty number} {student's first name} {student's second name}
    You should add the students untill you recieve "END" command.
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class StudentSpecialty
{
    public StudentSpecialty(string specialtyName, string facultyNumber)
    {
        this.SpecialtyName = specialtyName;
        this.FacultyNumberSp = facultyNumber;
    }

    public string SpecialtyName { get; set; }

    public string FacultyNumberSp { get; set; }
}

public class Student
{
    public Student(string facultyNumber, string studentName)
    {
        this.StudentName = studentName;
        this.FacultyNumberSt = facultyNumber;
    }

    public string StudentName { get; set; }

    public string FacultyNumberSt { get; set; }
}

public class Startup
{
    static void Main()
    {
        List<StudentSpecialty> studentSpecialties = new List<StudentSpecialty>();
        List<Student> students = new List<Student>();

        string line = Console.ReadLine();
        string[] lineAsArr;
        while (line != "Students:")
        {
            lineAsArr = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string specialtyName = string.Format("{0} {1}", lineAsArr[0], lineAsArr[1]);
            studentSpecialties.Add(new StudentSpecialty(specialtyName, lineAsArr[2]));

            line = Console.ReadLine();
        }

        line = Console.ReadLine();
        while (line != "END")
        {
            lineAsArr = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string studentName = string.Format("{0} {1}", lineAsArr[1], lineAsArr[2]);
            students.Add(new Student(lineAsArr[0], studentName));

            line = Console.ReadLine();
        }

        var studentsInSpecialties = studentSpecialties
            .Join(
                students,
                sp => sp.FacultyNumberSp,
                st => st.FacultyNumberSt,
                (sp, st) => new
                {
                    Name = st.StudentName,
                    FacNum = st.FacultyNumberSt,
                    Specialty = sp.SpecialtyName
                });

        foreach (var student in studentsInSpecialties)
        {
            Console.WriteLine(string.Format("{0} {1} {2}", student.Name, student.FacNum, student.Specialty));
        }
    }
}