using DemoConsole.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Models
{
    public class Employee :BaseEntity
    {
        public int PersonId { get; set; }
        public string EmployeeNumber { get; set; }
        public EmployeeType EmployeeType { get; set; }


    }
}
