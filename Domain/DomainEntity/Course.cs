﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainEntity
{
    public class Course
    {
        public int CourseId { get; set; }
        public string NameCourse { get; set; }
        public virtual List<Customer> customers { get; set; }

    }
}
