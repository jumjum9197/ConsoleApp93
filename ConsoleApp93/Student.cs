using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Linq
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Standard { get; set; }
        public Gender Gender { get; set; }

        public static List<Student> GetClasses()
        {
            return new List<Student>
            {
                new Student { RollNo = 101, Name = "Thomas", Gender = Gender.Male,    Standard = 10},
                new Student { RollNo = 102, Name = "Olaolu", Gender = Gender.Male,    Standard = 8},
                new Student { RollNo = 103, Name = "Chris",  Gender = Gender.Male,    Standard = 8},
                new Student { RollNo = 104, Name = "Funmi",  Gender = Gender.Female,  Standard = 10},
                new Student { RollNo = 105, Name = "Ron",    Gender = Gender.Male,    Standard = 7},
                new Student { RollNo = 106, Name = "Jimi",   Gender = Gender.Male,    Standard = 8},
                new Student { RollNo = 107, Name = "Kate",   Gender = Gender.Female,  Standard = 5},
                new Student { RollNo = 108, Name = "John",   Gender = Gender.Male,    Standard = 6},
                new Student { RollNo = 109, Name = "Ema",    Gender = Gender.Female,  Standard = 6},
                new Student { RollNo = 110, Name = "Ravi",   Gender = Gender.Male },

            };
        }

    }

    public enum Gender
    {
        Female,
        Male
    }

    public class Standard
    {
        public int id { get; set; }
        public string ClassTeacher { get; set; }
        public double Fees { get; set; }


        public static List<Standard> GetStandards()
        {
            return new List<Standard>
            {
                new Standard { id = 10, ClassTeacher = "Max", Fees = 100.000},
                new Standard { id = 8, ClassTeacher = "Ajayi", Fees = 800.000},
                new Standard { id = 6, ClassTeacher = "Geeta", Fees = 600.000},
                new Standard { id = 4, ClassTeacher = "Rohas", Fees = 400.000}
            };

        }
    }

    //public class Employee
    //{
    //    public string Name { get; set; }
    //    public int Id { get; set; }
    //    public Gender Gender { get; set; }
    //    public  double Salary { get; set; }
    //    public static List<Employee> GetMain()
    //    {
    //        return new List<Employee>
    //        {
    //            new Employee { Id = 1, Name = "lolo", Gender = Gender.Female,Salary= 89000 },
    //            new Employee { Id = 2, Name = "koko", Gender = Gender.Female,Salary= 189000 },
    //            new Employee { Id = 3, Name = "jojo", Gender = Gender.Female,Salary= 289000 },
    //            new Employee { Id = 4, Name = "john", Gender = Gender.Female,Salary= 389000 },
    //            new Employee { Id = 1, Name = "rich", Gender = Gender.Female,Salary= 489000 },
    //              new Employee { Id = 2, Name = "jumoke", Gender = Gender.Female,Salary= 89000 },
    //            new Employee { Id = 4, Name = "bukky", Gender = Gender.Female,Salary= 189000 },
    //            new Employee { Id = 3, Name = "tunde", Gender = Gender.Female,Salary= 289000 },
    //            new Employee { Id = 1, Name = "kanyin", Gender = Gender.Female,Salary= 389000 },
    //            new Employee { Id = 2, Name = "tife", Gender = Gender.Female,Salary= 489000 },
    //        };
    //    }
    //}
    //public enum Gender
    //{
    //    Male,
    //    Female

    //}
    //public class Supervisor
    //{
    //    public string Name { get; set;}
    //    public int Id { get; set; }
    //    public int Level { get; set; }
    //    public double Salary { get; set;}
    //    public Gender Gender { get; set; }

    //public static HashSet<Supervisor> GetMoon()
    //{
    //    return new HashSet<Supervisor>
    //    {
    //        new Supervisor { Name = "ife" , Id = 1, Gender =Gender.Male, Salary = 30000, Level = 8},
    //         new Supervisor { Name = "ayo" , Id = 2, Gender =Gender.Female, Salary = 130000, Level = 3 },
    //          new Supervisor { Name = "ola" , Id = 3, Gender =Gender.Male, Salary = 230000, Level = 7 },
    //           new Supervisor { Name = "oye" , Id = 4, Gender =Gender.Female, Salary = 530000, Level = 9 },
    //    };
    //}

}
    



