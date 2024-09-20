using ef_task1.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_task1.data
{
    internal class StudentSystemContext  : DbContext
        
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Resource> resources { get; set; }
        public DbSet<Homework> homeworks { get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystem ;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .Property(e => e.name)
                .HasColumnType("varchar(100)")
                .IsUnicode(true);

            modelBuilder.Entity<Student>()
               .Property(e => e.PhoneNumber)
               .HasColumnType("varchar(10)")
               .IsUnicode(false);

            modelBuilder.Entity<Course>()
               .Property(e => e.name)
               .HasColumnType("varchar(80)")
               .IsUnicode(true);

            modelBuilder.Entity<Course>()
               .Property(e => e.description)
               .IsUnicode(true);

            modelBuilder.Entity<Resource>()
               .Property(e => e.Name)
               .HasColumnType("varchar(50)")
               .IsUnicode(true);


        }
    }
}
