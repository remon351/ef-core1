using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_task1.models
{
    internal class Homework
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public Contenttype Contenttype { get; set; }
        public string SubmissionTime { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

    }
    public enum Contenttype 
    {
        application,
        pdf,
        zip
    }
}
