﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_task1.models
{

    [PrimaryKey(nameof(StudentId), nameof(CourseId))]
    internal class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }
    }
}
