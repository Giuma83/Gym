using Gym.Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Biz.Service
{
    public class CourseService
    {
        private readonly CourseRepository repo;

        public CourseService()
        {
            repo = new CourseRepository();
        }
        public void addCourse(Domain.DomainEntity.Course course)
        {
            repo.addCourse(course);
        }

        public void deleteCourse(int id)
        {
            repo.deleteCourse(id);
        }

        public List<Domain.DomainEntity.Course> readCourses()
        {
            var courses = repo.readCourses();
            return courses;
        }

        public string editCourse(Domain.DomainEntity.Course course)
        {
            return repo.editCourse(course);
        }
    }
}
