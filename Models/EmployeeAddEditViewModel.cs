using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class EmployeeAddEditViewModel
    {
        public Employee Employee { get; set; }
        public List<AppRefDataNisarg> StatusList { get; set; }
        public List<AppRefDataNisarg> EmployeeType { get; set; }
        public List<Emplist> WorkingCompanies { get; set; }
        public List<Emplist> WorkingLocations { get; set; }
        public List<Emplist> Departments { get; set; }
        public List<Emplist> BatchId { get; set; }
        public List<Emplist> HrRep { get; set; }
        public List<Emplist> Recruiters { get; set; }


    }
}