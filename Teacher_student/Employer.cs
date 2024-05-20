using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_student
{
    internal abstract class Employer
    {
        public Employer(int id, string name, string surname, string birthDate, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.birthDate = birthDate;
            this.Email = email;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string birthDate { get; set; }
        public string Email { get; set; }
    }
}
