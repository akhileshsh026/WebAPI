using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI_All_Sesions.Models;

namespace WebAPI_All_Sesions.Contracts
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();

        Employee GetEmployeeById(int id);
        void CreateEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
        void DeleteEmployee(int id);
    }
}