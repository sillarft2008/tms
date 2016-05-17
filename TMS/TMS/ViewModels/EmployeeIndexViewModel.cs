using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TMS.Models;

namespace TMS.ViewModels
{
    public class EmployeeIndexViewModel
    {
        public virtual Employee Employee { get; set; }
        public virtual Competency Competency { get; set; }


        public ICollection<Employee> Employees { get; set; }
        public ICollection<Competency> Competencies { get; set; }

        public ICollection<Employee_Competency> Employees_Competency { get; set; }
    }
}