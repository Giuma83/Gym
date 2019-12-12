using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gym.Presentation.Models
{
    public class CourseList
    {
        public CustomerModel customer { get; set; }
        public List<CourseModel> ListaCorsi { get; set; }
        public List<SubscriptionModel> ListaAbbonamenti { get; set; }
        public SubscriptionModel Subscription { get; set; }
    }
}