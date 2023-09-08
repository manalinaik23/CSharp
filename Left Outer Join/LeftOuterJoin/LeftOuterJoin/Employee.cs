using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftOuterJoin
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }

        public static List<Employee> getAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee{Id=1,Name="Manali",DepartmentId=1},
                new Employee{Id=2,Name="Sumit",DepartmentId=2},
                new Employee{Id=3,Name="Utkarsha",DepartmentId=2},
                new Employee{Id=4,Name="Sangeeta",DepartmentId=1},
                new Employee{Id=5,Name="Pooja"}
            };
        }
    }
}
