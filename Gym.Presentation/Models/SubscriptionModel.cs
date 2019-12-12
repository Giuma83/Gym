using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gym.Presentation.Models
{
    public class SubscriptionModel
    {
        public int SubscriptionId { get; set; }
        public string NameSubscription { get; set; }
        public virtual List<CustomerModel> Customers { get; set; }
    }
}