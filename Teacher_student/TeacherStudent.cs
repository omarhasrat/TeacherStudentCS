using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_student
{
    internal class TeacherStudent
    {
        public TeacherStudent(int id,Teacher teacher,Student student,int classNumber,string lesson)
        {
            this.Id = id;
            this.Teacher = teacher;
            this.Student = student;
            this.ClassNumber = classNumber;
            this.Lesson = lesson;
        }
        public int Id { get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        public int ClassNumber { get; set; }
        public string Lesson { get; set; }

       
    }
}
