using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApp.Core
{
    public class StudentsService
    {
        public List<Student> GetStudents()
        {
            return new List<Student> { new Student { Name = "Olanrewaju", Height = 123, StudentID = 1 }, new Student { Name = "Frank", Height = 123, StudentID = 2 } };
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
    }
}
