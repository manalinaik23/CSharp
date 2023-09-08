using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOperations
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
             List<string> stringList = new List<string>()
             {
                 "C# Tutorials",
                 "VB.NET Tutorials",
                 "Learn C++",
                 "MVC Tutorials" ,
                 "Java"
             };

            /*
             var result = from s in stringList
                          where s.StartsWith("L")
                          select s;*/

            /*LINQ Lambda Expression*/
            var resultList = stringList.Where(s => s.Contains("Tutorials")).ToList();
            /*LINQ lambda Expression*/

             foreach(var item in resultList)
             {
                 Console.WriteLine(item);
             }

             

            List<Student> studentList = new List<Student>
            {
                new Student(){StudentId =1,StudentName="Sumit Mane",StudentAge=28},
                new Student(){StudentId =2,StudentName="Utkarsha Sarang",StudentAge=26},
                new Student(){StudentId =3,StudentName="Manali Naik",StudentAge=27},
                new Student(){StudentId =4,StudentName="Sangeeta Lokhare",StudentAge=30},
                new Student(){StudentId =5,StudentName="Komal Naik",StudentAge=25}
            };

           /* var result = from s in studentList
                         where s.StudentAge <= 27
                         orderby s.StudentName
                         select s;

            /*LINQ lambda expression*/

            //var resulttest = studentList.Where(x => x.StudentName.Contains("Naik")).ToList<Student>();
            var result = studentList.OrderByDescending(x => x.StudentAge).ToList();
            /*LINQ lambda expression*/


            foreach (var item in result)
            {
                Console.WriteLine(item.StudentId+" "+item.StudentName+" "+item.StudentAge);
            }

            Console.WriteLine("---------------------------------------------");

            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add(1);
            mixedList.Add(2);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add("Three");
            mixedList.Add(new Student(){ StudentId = 10 ,StudentName= "Neha",StudentAge = 30});

            var mixedResult = from m in mixedList.OfType<Student>()
                              select m.StudentName;

            foreach(var item in mixedResult)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
