using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gym.Presentation.Models
{
    public class CourseModel
    {
        public int CourseId { get; set; }
        public string NameCourse { get; set; }
        public virtual List<CustomerModel> customers { get; set; }
    }
}