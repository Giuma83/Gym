using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionePalestraApi.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        
        public string NameCustomer { get; set; }
        
        public string SurnameCustomer { get; set; }
        
        public int Age { get; set; }
        public virtual List<CourseModel> Courses { get; set; }

        public virtual SubscriptionModel Subscription { get; set; }
        public bool Message { get; set; }

    }
}