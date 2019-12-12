using AutoMapper;
using Gym.Biz.Service;
using Gym.Presentation.MapperProfile;
using Gym.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gym.Presentation.Controllers
{
    public class SubscriptionController : Controller
    {
        private readonly SubscriptionService _service;
        private readonly DtoProfile _profile;
        Mapper mapper;
        MapperConfiguration config;

        public SubscriptionController()
        {
            _service = new SubscriptionService();
            _profile = new DtoProfile();
            config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(_profile);
            });
            mapper = new Mapper(config);
        }
        // GET: Subscription
        public ActionResult Index()
        {
            var model = new SubscriptionModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(SubscriptionModel subscription)
        {
            var subscriptionDomain = mapper.Map<Domain.DomainEntity.Subscription>(subscription);
            _service.addSubscription(subscriptionDomain);
            
            return View();
        }
    }
}