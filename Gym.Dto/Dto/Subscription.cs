using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Dto.Dto
{
    class Subscription
    {
        public int Id { get; set; }
        public string NameSubscription { get; set; }
        public virtual List<Customer> Customers { get; set; }
    }
}
