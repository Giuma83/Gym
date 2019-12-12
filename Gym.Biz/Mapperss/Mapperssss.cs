using Gym.Dal.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Biz.Mapperss
{
    public class Mapperssss
    {


        //public Gym.Biz.Entities.Course FromDaoToEntityCourse(Course course)
        //{
        //    var returned = new Gym.Biz.Entities.Course {NameCourse = course.NameCourse, Id = course.Id };
        //    return returned;
        //}

        //public Course FromEntityToDaoCourse(Gym.Biz.Entities.Course course)
        //{
        //    var returned = new Course { NameCourse = course.NameCourse, Id = course.Id };
        //    return returned;
        //}

        //public Gym.Biz.Entities.Customer FromDaoToEntityCustomer(Customer customer)
        //{
        //    var test = new List<Gym.Biz.Entities.Course>();
        //    foreach (var item in customer.Courses)
        //    {
        //        test.Add(FromDaoToEntityCourse(item));
        //    }


        //    var returned = new Gym.Biz.Entities.Customer { Age = customer.Age,
        //                                                    Courses = test,
        //                                                    NameCustomer = customer.NameCustomer, 
        //                                                    SubscriptionId = customer.SubscriptionId,
        //                                                    SurnameCustomer = customer.SurnameCustomer
        //                                                    };
        //    return returned;
        //}

        //public Customer FromEntityToDaoCustomer(Gym.Biz.Entities.Customer customer)
        //{

        //    var test = new List<Course>();
        //    foreach (var item in customer.Courses)
        //    {
        //        test.Add(FromEntityToDaoCourse(item));
        //    }

        //    var returned = new Customer {
        //                                 Age = customer.Age,
        //                                  Courses = test,
        //                                  NameCustomer = customer.NameCustomer,
        //                                  SubscriptionId = customer.SubscriptionId,
        //                                  SurnameCustomer = customer.SurnameCustomer };

        //    return returned;                               
        //}

        //public Gym.Biz.Entities.Subscription FromDaoToEntitySubscription(Subscription subscription)
        //{
        //    var test = new List<Gym.Biz.Entities.Customer>();
        //    foreach (var item in subscription.Customers)
        //    {
        //        test.Add(FromDaoToEntityCustomer(item));
        //    }
        //    var returned = new Gym.Biz.Entities.Subscription { Id = subscription.Id, NameSubscription = subscription.NameSubscription, Customers = test };
        //    return returned;
        //}

        //public Subscription FromEntityToDaoSubscription(Gym.Biz.Entities.Subscription subscription)
        //{
        //    var test = new List<Customer>();
        //    foreach (var item in subscription.Customers)
        //    {
        //        test.Add(FromEntityToDaoCustomer(item));
        //    }
        //    var returned = new Subscription { Id = subscription.Id, NameSubscription = subscription.NameSubscription, Customers = test };
        //    return returned;
        //}

    }
}
