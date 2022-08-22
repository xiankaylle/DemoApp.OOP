using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Models
{
    public class Person :BaseEntity
    {
        public Person()
        {
            EmailAddresses = new List<PersonEmailAddress>();
        }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BrithDate { get; set; }
        public Employee Employee { get; set; }
        public List<PersonEmailAddress> EmailAddresses { get; set; }

    }
}
