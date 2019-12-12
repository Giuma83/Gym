using AutoMapper;
using GestionePalestraApi.MapperApi;
using GestionePalestraApi.Models;
using Gym.Biz.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GestionePalestraApi.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomerApiController : ApiController
    {
        public CustomerModel _model;
        public CustomerService _service;
        private readonly ProfileApi _profile = new ProfileApi();
        Mapper mapper;
        MapperConfiguration config;
        public CustomerApiController()
        {
            _model = new CustomerModel();
            _service = new CustomerService();
            config = new MapperConfiguration(mpc =>
            {
                mpc.AddProfile(_profile);
            });
            mapper = new Mapper(config);
        }

        
        [HttpGet]
        [Route("Name=ViewAllCustomer/{CurrentPage}")]
        public IHttpActionResult Get(int CurrentPage)
        {
            try
            {
                var customerList = _service.ReadCustomers(CurrentPage);
                var apiCustomer = mapper.Map<List<CustomerModel>>(customerList);
                return Ok(apiCustomer);
            }
            catch (Exception e)
            {

                return InternalServerError(e);
            }
        }


        [HttpGet]
        [Route("Name=searchForId/{id}")]
        public IHttpActionResult GetId(int id)
        {
            try
            {
                var CustomerWithId = _service.ReadCustomerFromId(id);
                var FinalCustomer = mapper.Map<CustomerModel>(CustomerWithId);
                return Ok(FinalCustomer);
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
