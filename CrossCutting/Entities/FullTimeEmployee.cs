﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities
{
    public class FullTimeEmployee : Employee
    {
        public Nullable<int> Salary { get; set; }
    }
}
