using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECorp.backend
{
    public static class Employees
    {
        public static List<Employee> EmployeesList = new List<Employee>();
        public static List<Employee> CreateEmployees()
        {
            EmployeesList.Add(new Employee(1, "Jan", "Nowak", new DateTime(2002, 3, 4), "pracownik fizyczny", 18.5m, 0m));
            EmployeesList.Add(new Employee(2, "Agnieszka", "Kowalska", new DateTime(1973, 12, 15), "urzędnik",0m,2800m));
            EmployeesList.Add(new Employee(3, "Robert", "Lewandowski", new DateTime(1980, 5, 23), "pracownik fizyczny", 29m, 0m));
            EmployeesList.Add(new Employee(4, "Zofia", "Plucińska", new DateTime(1988, 11, 02), "urzędnik",0m, 4750m));
            EmployeesList.Add(new Employee(5, "Grzegorz", "Braun", new DateTime(1960, 1, 29), "pracownik fizyczny",48m, 0m));
            
            return EmployeesList;
        }
    }
}
