using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {
        public string FirstName;
        public string LastName;
        public int StudentId;
        public double AverageGrade;
        public Student (string firstname, string lastname, int studentid, double averagegrade)
        {
            FirstName = firstname;
            LastName = lastname;
            StudentId = studentid;
            AverageGrade = averagegrade;

        }
    }
}
