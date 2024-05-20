using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_student
{
    internal class Database
    {
        public static Teacher[] teachers = new Teacher[20];
        public static Student[] students = new Student[20];
        public static TeacherStudent[] teacher_Student = new TeacherStudent[20];
        public static int teacherId = 1;
        public static int studentId = 1;
        public static int teacherStudentId = 1;
    }
}
