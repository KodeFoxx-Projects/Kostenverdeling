using System;
using System.Linq;
using System.Collections.Generic;

namespace Kostenverdeling.Model.Common
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> Employees { get; } = new List<Employee>();

        public EmployeeRepository() {
        }

        public IEnumerable<Employee> GetEmployees() {
            return Employees;
        }

        public Employee GetEmployee(int id) {
            return Employees.Where(e => e.Id == id).SingleOrDefault();
        }        

        public Employee GetOrAddEmployee(int id, string name) {
            var employee = GetEmployee(id);

            if(employee == null) {
                employee = new Employee {
                    Id = id,
                    Name = name
                };
                Employees.Add(employee);
            }

            return employee;
        }
    }
}
