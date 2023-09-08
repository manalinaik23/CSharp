// See https://aka.ms/new-console-template for more information
using LeftOuterJoin;

var result = from e in Employee.getAllEmployees()
             join d in Department.GetDepartments()
             on e.DepartmentId equals d.Id into eGroups
             from d in eGroups.DefaultIfEmpty()
             select new
             {
                 EmployeName = e.Name,
                 DepartmentName = d == null ? "No department":d.Name,
             };
//DefaultIfEmpty() : we will get null if employee is not having department associated with.

foreach (var r in result)
{
    Console.WriteLine(r.EmployeName+" "+r.DepartmentName);
}
