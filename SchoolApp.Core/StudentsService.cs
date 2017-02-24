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
            return new List<Student> { new Student { Email = "Olanrewaju@yahoo.com", Name = "Olanrewaju", StudentID = 1 }, new Student { Email = "Frank", Name = "Frank", StudentID = 2 } };
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string HomeAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}
