using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreuygulama.Models
{
    public class Repository
    {
        public static List<Student> student  = new List<Student>();
        public static List<Student> Students
        {
            get { return student; }
        }
        public static void AddStudent(Student stu)
        {
            student.Add(stu);
        }
    }
}
