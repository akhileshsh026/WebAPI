using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI_All_Sesions.Contracts;

namespace WebAPI_All_Sesions.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        static List<Employee> empList = new List<Employee>
        {
            new Employee {Id=1,Name="Akhilesh",Location="Mandla",salary=77864 },
            new Employee {Id=2,Name="Akhilesh1",Location="Mandla1",salary=87864 },
            new Employee {Id=3,Name="Akhilesh2",Location="Mandla2",salary=97864 },
            new Employee {Id=4,Name="Akhilesh3",Location="Mandla3",salary=177864 },
        };

        public void CreateEmployee(Employee emp)
        {
            empList.Add(emp);
        }

        public void DeleteEmployee(int id)
        {
            empList.Remove(empList.FirstOrDefault(e => e.Id == id));
        }

        public List<Employee> GetAll()
        {
            return empList;
        }

        public Employee GetEmployeeById(int id)
        {
            return empList.FirstOrDefault(e => e.Id == id);
        }

        public void UpdateEmployee(Employee emp)
        {
            Employee TempEmp = empList.FirstOrDefault(e => e.Id == emp.Id);
            TempEmp.Name = emp.Name;
            TempEmp.Location = emp.Location;
            TempEmp.salary = emp.salary;
          
        }
    }
}