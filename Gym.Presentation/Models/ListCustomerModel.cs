using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gym.Presentation.Models
{
    public class ListCustomerModel
    {
        public List<CustomerModel> customers { get; set; }
        public CustomerModel customer { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
    }
}