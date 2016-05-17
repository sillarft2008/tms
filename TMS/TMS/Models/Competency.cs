using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace TMS.Models
{
    public class Competency
    {
        [Key]
        public int Id { get; set; }
        public string Competencies { get; set; }

        public void setCompetency(localhostCompetency.Competency competency)
        {
            this.Id = competency.id;
            this.Competencies = competency.competency;
        }

        public localhostCompetency.Competency getCompetency()
        {
            localhostCompetency.Competency competency = new localhostCompetency.Competency();
            competency.id = this.Id;
            competency.competency = this.Competencies;
            return competency;
        }

         public virtual ICollection<Employee_Competency> Employee_Competencies { get; set; }
         public virtual ICollection<Employee> Employees { get; set; }

    }
}