﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_student
{
    internal class Student : Employer
    {
        public Student(int id, string name, string surname, string birthDate, string email) : base(id, name, surname,birthDate, email)
        {
        }
    }
}
