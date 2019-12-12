using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainEntity
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string NameCustomer { get; set; }
        public string SurnameCustomer { get; set; }
        public int Age { get; set; }
        public virtual List<Course> Courses { get; set; }
     
        public virtual Subscription Subscription { get; set; }
    }
}
