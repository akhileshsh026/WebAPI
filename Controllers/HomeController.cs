using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_All_Sesions.Contracts;
using WebAPI_All_Sesions.Models;

namespace WebAPI_All_Sesions.Controllers
{
    public class HomeController : ApiController
    {
        IEmployeeRepository repo;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            repo = employeeRepository;
        }

        public List<Employee> GetAll()
        {
            return repo.GetAll();

        }

        public Employee GetById(int Id)
        {
            return repo.GetEmployeeById(Id);
        }

        public void Post(Employee emp)
        {
            repo.CreateEmployee(emp);
        }

        public void Put()
        {

        }

        public void Delete(int id)
        {
            repo.DeleteEmployee(id);
        }
    }
}
