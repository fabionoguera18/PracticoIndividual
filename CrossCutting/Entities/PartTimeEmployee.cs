﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities
{
    public class PartTimeEmployee : Employee
    {
        public Nullable<double> HourlyRate { get; set; }
    }
}
