using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherApp
{
    public class Teacher
    {
        public event Action StudentSubmitedHomework;
        public event Action CheckHomeWorkNow;

        public void CollectHomework()
        {
            StudentSubmitedHomework?.Invoke();
        }
        public void CheckHomeWork()
        {
            CheckHomeWorkNow?.Invoke();
        }
    }
}
