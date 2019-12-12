using AutoMapper;
using Gym.Dal.AutoMapper;
using Gym.Dal.Dao;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Dal.Repository
{
    public class CourseRepository
    {
        private readonly Context _context;
        private readonly DalProfile _profile;
        Mapper mapper;
        MapperConfiguration config;
        public CourseRepository()
        {
            _context = new Context();
            _profile = new DalProfile();
            var config = new MapperConfiguration(cfm =>
            {
                cfm.AddProfile(_profile);
            });
            mapper = new Mapper(config);
        }

        public void addCourse(Domain.DomainEntity.Course course)
        {
            var courseDal = mapper.Map<Gym.Dal.Dao.Course>(course);
            _context.Courses.Add(courseDal);
            _context.SaveChanges();
        }

        public string deleteCourse(int id)
        {
            var delCourse = _context.Courses.Where(x => x.CourseId == id).FirstOrDefault()
                ;
            _context.Courses.Remove(delCourse);
            
            return "cliente eliminato";
        }

        public List<Domain.DomainEntity.Course> readCourses()
        {
            var daoCourse = _context.Courses.ToList();
            var courses = mapper.Map<List<Domain.DomainEntity.Course>>(daoCourse);
            return courses;
        }

        public string editCourse(Domain.DomainEntity.Course course)
        {
            var definitiveCourse = mapper.Map<Gym.Dal.Dao.Course>(course);
            var courseChanged = _context.Courses.Where(x => x.CourseId == definitiveCourse.CourseId).FirstOrDefault();

            if (courseChanged != null)
            {
                _context.Courses.AddOrUpdate(courseChanged);
                _context.SaveChanges();
                return "cliente modificato";
            }
            else
            {
                return "cliente non trovato";
            }
            
            
        }

    }
}
