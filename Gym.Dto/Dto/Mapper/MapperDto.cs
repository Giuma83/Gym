using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Dto.Dto.Mapper
{
    class MapperDto
    {
        public Gym.Biz.Entities.Course FromDtoToEntityCourse(Course course)
        {
            var returned = new Gym.Biz.Entities.Course { Id = course.Id, NameCourse = course.NameCourse };
            return returned;
        }
        public Course FromEntityToDtoCourse(Gym.Biz.Entities.Course course)
        {
            var returned = new Course { Id = course.Id, NameCourse = course.NameCourse };
            return returned;
        }

        public Gym.Biz.Entities.Customer FromDtoToEntityCustomer(Customer customer)
        {
            var test = new List<Gym.Biz.Entities.Course>();
            foreach (var item in customer.Courses)
            {
                test.Add(FromDtoToEntityCourse(item));
            }

           var returned = new Gym.Biz.Entities.Customer {
                                        Age = customer.Age,
                                        Courses = test,
                                        Id = customer.Id,
                                         NameCustomer = customer.NameCustomer,
                                         SubscriptionId = customer.SubscriptionId,
                                        SurnameCustomer = customer.SurnameCustomer};
            return returned;
        }

        public Customer FromEntityToDaoCustomer(Gym.Biz.Entities.Customer customer)
        {
            var test = new List<Course>();
            foreach (var item in customer.Courses)
            {
                test.Add(FromEntityToDtoCourse(item));
            }

            var returned = new Customer
            {
                Age = customer.Age,
                Courses = test,
                Id = customer.Id,
                NameCustomer = customer.NameCustomer,
                SubscriptionId = customer.SubscriptionId,
                SurnameCustomer = customer.SurnameCustomer
            };
            return returned;

        }

        public Gym.Biz.Entities.Subscription FromDtoToEntitySubscription(Subscription subscription)
        {
            var test = new List<Gym.Biz.Entities.Customer>();
            foreach (var item in subscription.Customers)
            {
                test.Add(FromDtoToEntityCustomer(item));
            }

            var returned = new Gym.Biz.Entities.Subscription
            {
                Customers = test,
                Id = subscription.Id,
                NameSubscription =
                subscription.NameSubscription
            };
            return returned;
        }

        public Subscription FromEntityToDtoSubscription(Gym.Biz.Entities.Subscription subscription)
        {
            var test = new List<Customer>();
            foreach (var item in subscription.Customers)
            {
                test.Add(FromEntityToDaoCustomer(item));
            }

            var returned = new Subscription
            {
                Customers = test,
                Id = subscription.Id,
                NameSubscription =
                subscription.NameSubscription
            };
            return returned;
        }
    
    }
}
