﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Models
{
    public class PersonEmailAddress : BaseEntity
    {
        public int PersonId { get; set; }
        public string? EmailAddress { get; set; }
        public bool IsPrimary { get; set; }

    }
}
