using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherApp
{
    public class Student
    {
        public Student(Teacher newTeacher)
        {
            newTeacher.StudentSubmitedHomework += SubmitHomeWork;
            newTeacher.CheckHomeWorkNow += CheckHomeWork;
        }

        public void SubmitHomeWork()
        {
            Console.WriteLine("Submitted the homework");
        }
        public void CheckHomeWork()
        {
            Console.WriteLine("Checked the homework");
        }
    }
}
