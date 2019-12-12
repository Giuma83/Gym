using AutoMapper;
using Gym.Dal.AutoMapper;
using Gym.Dal.Dao;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Dal.Repository
{
    public class SubscriptionRepository
    {
        private readonly Context _context;
        private readonly DalProfile _profile;
        private readonly Mapper mapper;
        private readonly MapperConfiguration config;

        public SubscriptionRepository()
        {
            _context = new Context();
            _profile = new DalProfile();
            config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(_profile);
            });
            mapper = new Mapper(config);
        }


        public void addSubscription(Domain.DomainEntity.Subscription subscription)
        {
            var finalSubscription = mapper.Map<Gym.Dal.Dao.Subscription>(subscription);
            _context.Subscriptions.Add(finalSubscription);
            _context.SaveChanges();
        }

        public void deleteSubscription(int id)
        {
            var subscriptionToDelete = _context.Subscriptions.Where(x => x.SubscriptionId == id).FirstOrDefault();
            _context.Subscriptions.Remove(subscriptionToDelete);
            _context.SaveChanges();
        }

        public List<Domain.DomainEntity.Subscription> readSubscription()
        {
            var lSub = _context.Subscriptions.ToList();
            var listSub = mapper.Map<List<Subscription>, List<Domain.DomainEntity.Subscription>>(lSub);
            return listSub;
        }

        public string editSubscription(Domain.DomainEntity.Subscription subscription)
        {
            var changeSub = mapper.Map<Gym.Dal.Dao.Subscription>(subscription);
            var sub = _context.Subscriptions.Where(x => x.SubscriptionId == changeSub.SubscriptionId).FirstOrDefault();

                if (sub != null)
            {
                _context.Subscriptions.AddOrUpdate(sub);
                _context.SaveChanges();
                return "utente modificato";
            }
            return "la modifica non è andata a buon fine";
        }
    }
}
