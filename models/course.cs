using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_task1.models
{
    internal class Course
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public ICollection<Homework> homeworks { get; set; } = new List<Homework>();
        public ICollection<Resource> resources { get; set; } = new List<Resource>();
        public ICollection<Student> students { get; set; } = new List<Student>();
    }
}
