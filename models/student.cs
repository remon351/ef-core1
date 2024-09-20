using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_task1.models
{
    internal class Student
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string? PhoneNumber  { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateOnly? Birthday { get;}
        public ICollection<Homework> homeworks { get; set; } = new List<Homework>();
        public ICollection<Course> courses { get; set; } = new List<Course>();
    }
}
