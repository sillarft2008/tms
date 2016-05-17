using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using TMS.Models;

namespace TMS.Repositories
{
        public interface IEmployeeCompetencyRepository
        {
        IEnumerable<Employee_Competency> All { get; }

        Employee_Competency Find(int? id);
        void InsertOrUpdate(Employee_Competency dude);
        void Delete(int id);

    }
    public class EmployeeCompetencyRepository : IEmployeeCompetencyRepository
    {
        localhostEC.EmployeeCompetencyWebserviceService ECW = new localhostEC.EmployeeCompetencyWebserviceService();
        localhostEC.EmployeeCompetency employee = new localhostEC.EmployeeCompetency();


        IEnumerable<Employee_Competency> IEmployeeCompetencyRepository.All
        {
            get
            {
                List<Employee_Competency> employeeList = new List<Employee_Competency>();

                localhostEC.EmployeeCompetency[] pancake = ECW.getAllEmployeeCompetencies();
                ECW.Timeout = 2000;

                Employee_Competency employee;
                foreach (localhostEC.EmployeeCompetency e in pancake)
                {
                    employee = new Employee_Competency();
                    employee.setEmployeeCompetency(e);
                    employeeList.Add(employee);
                }
                IEnumerable<Employee_Competency> l = employeeList.ToList();
                return l;

            }
        }

        public Employee_Competency Find(int? id)
        {
            Employee_Competency employee = new Employee_Competency();
            employee.setEmployeeCompetency(ECW.findEmployeeCompetency((int)id));
            return employee;
        }

        public void InsertOrUpdate(Employee_Competency dude)
        {
            if (dude.Id == default(int)) //if it is default int(0) than it is a new movie
            {
                employee = dude.getEmployeeCompetency();
                ECW.Timeout = 2000;
                String result = ECW.createEmployeeCompetency(employee);
            }
            else
            {
                employee = dude.getEmployeeCompetency();
                ECW.Timeout = 2000;
                String result = ECW.updateEmployeeCompetency(employee);
            }
        }

        public void Delete(int id)
        {
            ECW.Timeout = 2000;
            localhostEC.EmployeeCompetency delete = ECW.findEmployeeCompetency((int)id);
            ECW.deleteEmployeeCompetency(delete);
        }
    }
}