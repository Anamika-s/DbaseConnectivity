using EFCoreDemo.DataContext;
using EFCoreDemo.Models;

namespace EFCoreDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // perform CRUD operations
            // C > Create / Insert
            // R > Read / Get Data
            // U > Update
            // D > Delete

            // We need instance of DbContext

            EmployeeDbContext employeeDbContext = new EmployeeDbContext();
            // it become mediator between collection & the table in the backend

            // we will use LINQ 
            // Get records
            //var employees = (from x in employeeDbContext.Employees
            //                 select x).ToList();

            var employees = employeeDbContext.Employees.ToList();

            Console.WriteLine("Employees List");
            if (employees.Count() > 0)
            {
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.Name + " " + employee.Id + "  " + employee.Dept + " " + employee.Exp);
                }
            }
            else
            {
                Console.WriteLine("there are no records");
            }

            // add record 
            // object initializer by using properties
            Employee employee1 = new Employee()
            {
                Name = "Vijay",
                Dept = "HR",
                Exp = 9
            };
            employeeDbContext.Employees.Add(employee1);
            employeeDbContext.SaveChanges();

            // update record

            //Employee empToChange = employeeDbContext.Employees
            //    .FirstOrDefault(x => x.Id == 1);
            foreach (var employee in employees)
            {
                if (employee.Id == 2)
                {
                    employee.Name = "new name";
                }
            }
            employeeDbContext.SaveChanges();

            // delete record

            //Employee empToDelete = employeeDbContext.Employees.FirstOrDefault(x => x.Id == 1);
            //foreach (var employee in employees)
            //{
            //    if (employee.Id == 1)
            //    {
            //        employeeDbContext.Employees.Remove(employee);

            //    }
            //    employeeDbContext.SaveChanges();
            //}
        }
    }
}