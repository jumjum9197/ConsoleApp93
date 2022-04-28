using System;
using System.Collections.Generic;
using System.Linq;


namespace Employee.Linq
{
    public class Program
    {
        static void Main()
        {
            var allstudent = Student.GetClasses();
            var teacher = Standard.GetStandards();

            //Query syntax join
            var data = from b in allstudent
                       join x in teacher
                       on b.Standard equals x.id
                       select new
                       {
                           b.Name,
                           x.ClassTeacher,
                           x.id,
                           b.Gender,
                           b.Standard
                       };
            foreach (var item in data)
            {
                Console.WriteLine($"teacher: {item.ClassTeacher} name: {item.Name} id:{item.id} standard:{item.Standard}");
            }
            //   //Extention method/BasedSyntax join
            //   var newdata = allstudent.Join(teacher,
            //                               b => b.Standard,
            //                               x => x.id, (bt, x1) => new
            //                               {
            //                                   bt.Name,
            //                                   x1.ClassTeacher,
            //                                   bt.Standard,
            //                                   bt.Gender,
            //                                   x1.Fees

            //                               }).Where(b => b.Standard > 6)
            //                                 .OrderByDescending(x => x.Fees);



            //   foreach (var alldata in newdata)
            //   {
            //       Console.WriteLine($"StudentName {alldata.Name}: Teacher: {alldata.ClassTeacher} ID: {alldata.Standard}");
            //   }

            //   //GroupJoin
            //   // query
            //   var data1 = from d in teacher
            //              join c in allstudent
            //              on d.id equals c.Standard into groupedteacher
            //              select new
            //              {
            //                  d.id,
            //                  d.ClassTeacher,
            //                  groupedteacher
            //              };
            //   foreach (var item in data1)
            //   {
            //       Console.WriteLine($"Name: {item.ClassTeacher} ");
            //       foreach (var itempro in item.groupedteacher)
            //       {
            //           Console.WriteLine($"----{itempro.Name}------{itempro.RollNo}      {itempro.Gender}");
            //       }
            //   }
            //   Console.WriteLine( "***************************************************\n");

            //var jum = teacher.GroupJoin(allstudent,
            //                           b => b.id,
            //                           x => x.Standard, (bt, groupedteacher) => new
            //                           {
            //                               bt.ClassTeacher,
            //                                bt.id,

            //                               groupedteacher
            //                           });

            //   foreach (var item in jum)
            //   {
            //       Console.WriteLine($"Name: {item.ClassTeacher} : Id: {item.id}");
            //       foreach (var itempro in item.groupedteacher )
            //       {
            //           Console.WriteLine($"----{itempro.Name}------{itempro.RollNo}");
            //       }
            //   }

            //var emp = Employee.GetMain();
            //var sup = Supervisor.GetMoon();

            //var data = emp.Select(x => x.Id >2);
            //foreach (var item in data)
            //{
            //    Console.WriteLine(data.Nam);
            //}
        }
    }
}