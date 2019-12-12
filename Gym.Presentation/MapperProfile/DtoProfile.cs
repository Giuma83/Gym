using AutoMapper;
using Gym.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gym.Presentation.MapperProfile
{
    public class DtoProfile : Profile
    {
        public DtoProfile()
        {
            CreateMap<CustomerModel, Domain.DomainEntity.Customer>().ReverseMap();
            
            CreateMap<CourseModel, Domain.DomainEntity.Course>().ReverseMap();

            CreateMap<SubscriptionModel, Domain.DomainEntity.Subscription>().ReverseMap();
        }
    }
}