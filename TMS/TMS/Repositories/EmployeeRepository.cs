using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TMS.Models;

namespace TMS.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> All { get; }

        Employee Find(int? id);
        void InsertOrUpdate(Employee dude);
        void Delete(int id);

    }
    public class EmployeeRepository : IEmployeeRepository
    {
        localhostEmployee.EmployeeWebserviceService EWS = new localhostEmployee.EmployeeWebserviceService();
        localhostEmployee.Employee employee = new localhostEmployee.Employee();

     
        IEnumerable<Employee> IEmployeeRepository.All
        {
            get
            {
                List<Employee> employeeList = new List<Employee>();

                localhostEmployee.Employee[] pancake = EWS.getAllEmployees();
                EWS.Timeout = 2000;

                Employee employee;
                foreach (localhostEmployee.Employee e in pancake)
                {
                    employee = new Employee();
                    employee.setEmployee(e);
                    employeeList.Add(employee);
                }
                IEnumerable<Employee> l = employeeList.ToList();
                return l;
                
            }
        }

        public Employee Find(int? id)
        {
            Employee employee = new Employee();
            employee.setEmployee(EWS.findEmployee((int)id));
            return employee;
        }

        public void InsertOrUpdate(Employee dude)
        {
            if (dude.Id == default(int)) //if it is default int(0) than it is a new movie
            {
                employee = dude.getEmployee();
                EWS.Timeout = 2000;
                String result = EWS.createEmployee(employee);
            }
            else
            {
                employee = dude.getEmployee();
                EWS.Timeout = 2000;
                String result = EWS.updateEmployee(employee);
            }
        }

        public void Delete(int id)
        {
            EWS.Timeout = 2000;
            localhostEmployee.Employee delete = EWS.findEmployee((int)id);
            EWS.deleteEmployee(delete);
        }
    }
}