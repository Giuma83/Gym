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
    public class CourseController : Controller
    {
        private readonly CourseModel model;
        private readonly CourseService _service;
        private readonly DtoProfile _profile;
        Mapper mapper;
        MapperConfiguration config;

        public CourseController()
        {
            model = new CourseModel();
            _service = new CourseService();
            _profile = new DtoProfile();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(_profile);
            });
            mapper = new Mapper(config);
        }

        // GET: Course
        public ActionResult addCourse()
        {
            return View(model);
        }

        [HttpPost]
        public ActionResult addCourse(CourseModel course)
        {
            var domainCourse = mapper.Map<Domain.DomainEntity.Course>(course);
            _service.addCourse(domainCourse);
            return View();
        }

    }
}