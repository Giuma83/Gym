using AutoMapper;
using Gym.Dal.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DomainEntity;

namespace Gym.Dal.AutoMapper
{
    public class DalProfile : Profile
    {
       
        public DalProfile()
        {
            CreateMap<Domain.DomainEntity.Customer, Gym.Dal.Dao.Customer>().ReverseMap();

            CreateMap<Domain.DomainEntity.Course, Gym.Dal.Dao.Course>().ReverseMap();

            CreateMap<Domain.DomainEntity.Subscription, Gym.Dal.Dao.Subscription>().ReverseMap();
        }
    }
}
