using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TMS.Models
{
    public class Employee_Competency
    {
        [Key]
        public int Id { get; set; }
        public int employeeId { get; set; }
        public int competencyId { get; set; }

        public void setEmployeeCompetency(localhostEC.EmployeeCompetency ec)
        {
            this.Id = ec.id;
            this.employeeId = ec.employeeId;
            this.competencyId = ec.competencyId;

        }

        public localhostEC.EmployeeCompetency getEmployeeCompetency()
        {
            localhostEC.EmployeeCompetency ec = new localhostEC.EmployeeCompetency();
            ec.id = this.Id;
            ec.employeeId = this.employeeId;
            ec.competencyId = this.competencyId;

            return ec;
        }

        public virtual Employee Employee { get; set; }
        public virtual Competency Competency { get; set; }
    }
}