using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Code1stPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            CollegeDBContext context = new CollegeDBContext();
            var student = context.Students;
            //var student1 = student.Add(new Student()
            //{
            //    ID = 1001,
            //    StuName = "Sai Ram",
            //    StuPY = 2019,
            //    DepID = 1
            //});
            //var student2 = student.Add(new Student()
            //{
            //    ID = 1002,
            //    StuName = "Venu",
            //    StuPY = 2019,
            //    DepID = 1
            //});
            //var student3 = student.Add(new Student()
            //{
            //    ID = 1003,
            //    StuName = "Vignesh",
            //    StuPY = 2019,
            //    DepID = 2
            //});
            var student4 = student.Add(new Student()
            {
                ID = 1004,
                StuName = "Milan",
                StuPY = 2019,
                DepID = 2

            });
            var student5 = student.Add(new Student()
            {
                ID = 1005,
                StuName = "Jagan",
                StuPY = 2019,
                DepID = 3

            });

            var Department = context.Departments;
            //var Department1 = Department.Add(new Department()
            //{
            //    id = 1,
            //    DepName = "CSE"
            //});
            //var Department2 = Department.Add(new Department()
            //{
            //    id = 2,
            //    DepName = "ECE"
            //});
            var Department2 = Department.Add(new Department()
            {
                id = 3,
                DepName = "MECHANICAL"
            });

            context.SaveChanges();

        }
        
    }
    public class CollegeDBContext : DbContext
    {
        public CollegeDBContext() :
         base("name = CollegeDBContext")
        { }
        public DbSet<Student>    Students    { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
    public class Student
    {
        public int    ID   { get; set; }
        public string StuName { get; set; }
        public int    StuPY   { get; set; }
        public int    DepID   { get; set; }

    }
    public class Department
    {
        public int   id   { get; set; }
        public string DepName { get; set; }
    }
}
