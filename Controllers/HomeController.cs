using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_All_Sesions.Models;

namespace WebAPI_All_Sesions.Controllers
{
    public class HomeController : ApiController
    {
        static List<Employee> empList = new List<Employee>
        {
            new Employee {Id=1,Name="Akhilesh",Location="Mandla",salary=77864 },
            new Employee {Id=2,Name="Akhilesh1",Location="Mandla1",salary=87864 },
            new Employee {Id=3,Name="Akhilesh2",Location="Mandla2",salary=97864 },
            new Employee {Id=4,Name="Akhilesh3",Location="Mandla3",salary=177864 },
        };

        public List<Employee> GetAll()
        {
            return empList;

        }

        public Employee GetById(int Id)
        {
            return empList.FirstOrDefault(e => e.Id == Id);
        }

        public void Post(Employee emp)
        {
            empList.Add(emp);
        }

        public void Put()
        {

        }

        public void Delete(int id)
        {
            empList.Remove(empList.FirstOrDefault(e => e.Id == id));
        }
    }
}
