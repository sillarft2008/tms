using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TMS.Models;

namespace TMS.ViewModels
{
    public class EmployeeCompetencyViewModel
    {
        // [HiddenInput(DisplayValue = false)]
        public Employee Employee { get; set; }
        public Competency Competency { get; set; }


        public List<Competency> Competencies { get; set; }
    }
}