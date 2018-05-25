using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp.BLL.Models
{
    public class EmployeeDTO: BaseDTO
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EmploymentDate { get; set; }
    }
}