using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TMS.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [Display(Name = "Birth Date", Prompt = "YYYY-MM-dd")]
        public string BirthDate { get; set; }
        [Display(Name = "Home Address")]
        public string HomeAddress { get; set; }

        public void setEmployee(localhostEmployee.Employee employee)
        {
            this.Id = employee.id;
            this.FirstName = employee.firstName;
            this.LastName = employee.lastName;
            this.Email = employee.email;
            this.HomeAddress = employee.address;
            this.Phone = employee.telefone;
            this.BirthDate = employee.birthdate;

        }

        public localhostEmployee.Employee getEmployee()
        {
            localhostEmployee.Employee empployee = new localhostEmployee.Employee();
            empployee.id = this.Id;
            empployee.firstName = this.FirstName;
            empployee.lastName = this.LastName;
            empployee.email = this.Email;
            empployee.address = this.HomeAddress;
            empployee.telefone = this.Phone;
            empployee.birthdate = this.BirthDate;

            return empployee;
        }

         public virtual ICollection<Employee_Competency> Employee_Competencies { get; set; }
         public ICollection<Competency> Competencies { get; set; }

    }
}