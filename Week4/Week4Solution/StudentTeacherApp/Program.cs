using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher thisTeacher = new Teacher();
            new Student(thisTeacher);
            new Student(thisTeacher);
            new Student(thisTeacher);
            new Student(thisTeacher);
            new Student(thisTeacher);
            thisTeacher.CollectHomework();
            Console.WriteLine();
            thisTeacher.CheckHomeWork();

            Console.ReadKey();
        }
    }
}
