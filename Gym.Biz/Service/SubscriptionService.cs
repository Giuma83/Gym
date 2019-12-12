using Gym.Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Biz.Service
{
    public class SubscriptionService
    {
        private readonly SubscriptionRepository repo;

        public SubscriptionService()
        {
            repo = new SubscriptionRepository();
        }

        public void addSubscription(Domain.DomainEntity.Subscription subscription)
        {
            repo.addSubscription(subscription);
        }

        public void deleteSubscription(int id)
        {
            repo.deleteSubscription(id);
        }

        public List<Domain.DomainEntity.Subscription> readSubscription()
        {
            var listSub = repo.readSubscription();
            return listSub;
        }

        public string editSubscription(Domain.DomainEntity.Subscription subscription)
        {
            return repo.editSubscription(subscription);
        }

    }
}
