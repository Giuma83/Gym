using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gym.Presentation.Models
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        [DisplayName("Nome")]
        public string NameCustomer { get; set; }
        [DisplayName("Cognome")]
        public string SurnameCustomer { get; set; }
        [DisplayName("Età")]
        public int Age { get; set; }
        public virtual List<CourseModel> Courses { get; set; }
       
        public virtual SubscriptionModel Subscription { get; set; }
        public bool Message { get; set; }
    }
}