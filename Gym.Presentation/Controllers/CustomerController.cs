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
    public class CustomerController : Controller
    {
        private readonly CustomerService service;
        public DtoProfile _profile;
        private Mapper mapper;
        MapperConfiguration config;

        public CustomerController()
        {
            service = new CustomerService();
            _profile = new DtoProfile();
            config = new MapperConfiguration(x =>
            {
                x.AddProfile(_profile);
            });
            mapper = new Mapper(config);
        }
        // GET: Customer
        public ActionResult AddCustomer()
        {
            var cModel = new CustomerModel();
            cModel.Message = false;
            return View(cModel);
        }
        [HttpPost]
        public ActionResult AddCustomer(CustomerModel customer)
        {
            var cModel = new CustomerModel();
            var customerMapped = mapper.Map<Domain.DomainEntity.Customer>(customer);
            service.AddCustomer(customerMapped);
            cModel.Message = true;
            return View(cModel);
        }

        
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult AddCustomerWithCourses()
        {
            var subscriptionsAndCourse = new CourseList();
            var serviceCourse = new CourseService();
            var serviceSubscription = new SubscriptionService();
            var servSub = serviceSubscription.readSubscription();
            var servCor = serviceCourse.readCourses();
            var listSub = mapper.Map<List<SubscriptionModel>>(servSub);
            var listCourse = mapper.Map<List<CourseModel>>(servCor);

            subscriptionsAndCourse.ListaAbbonamenti = listSub;
            subscriptionsAndCourse.ListaCorsi = listCourse;
            return View(subscriptionsAndCourse);
        }

        [HttpPost]
        public ActionResult AddCustomerWithAll(CourseList dati)
        {
            var customer = dati.customer;
            var courses = dati.ListaCorsi;
            var subscription = dati.Subscription;
            customer.Subscription = subscription;
            customer.Courses = courses;
            var customerDomain = mapper.Map<Domain.DomainEntity.Customer>(customer);
            service.AddCustomer(customerDomain);
            return View();
        }


        public ActionResult ListCustomerGym()
        {
            return View();
        }

       
        public ActionResult ViewCustomerList(int currentPage)
        {
            var mario = new ListCustomerModel();
            var customerDomain = service.ReadCustomers(currentPage);
            var customer = mapper.Map<List<CustomerModel>>(customerDomain);
            mario.customers = customer;
            mario.CurrentPage = currentPage;
            mario.PageCount = service.GetPageCount();
            return View(mario);
        }

        public ActionResult DetailsCustomer(int id)
        {
            var mario = new ListCustomerModel();
            var customerDomain = service.ReadCustomerFromId(id);
            var customerDto = mapper.Map<CustomerModel>(customerDomain);
            mario.customer = customerDto;
            return PartialView(mario);
        }

        public ActionResult EditCustomer(int id)
        {
            var customerDomain = service.ReadCustomerFromId(id);
            var customerDto = mapper.Map<CustomerModel>(customerDomain);
            return View(customerDto);
        }
        [HttpPost]
        public ActionResult UploadCustomer(CustomerModel customer)
        {
            var customerDomain = mapper.Map<Domain.DomainEntity.Customer>(customer);
            service.EditCustomer(customerDomain);
            return RedirectToAction("ViewCustomerList");
        }


        public ActionResult ciao()
        {
            return View();
        }

    }  
}