using AutoMapper;
using GestionePalestraApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionePalestraApi.MapperApi
{
    public class ProfileApi : Profile
    {
        public ProfileApi()
        {
            CreateMap<CustomerModel, Domain.DomainEntity.Customer>().ReverseMap();
            CreateMap<CourseModel, Domain.DomainEntity.Course>().ReverseMap();
            CreateMap<SubscriptionModel, Domain.DomainEntity.Subscription>();
        }
    }
}