using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseInfo_api_microservice.Entity;

namespace CourseInfo_api_microservice.DataLayer
{
    public class CourseService
    {
        private readonly CourseContext _context;

        public CourseService(CourseContext context)
        {
            _context = context;
        }

        public Course AddCourse(Course newCourse)
        {
            _context.Course.Add(newCourse);
            return _context.Course.Last();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            var query = from c in _context.Course
                        orderby c.Id
                        select c;
            return query.ToList();
        }

        public Course GetACourse(int courseId)
        {
            var query = from c in _context.Course
                        where c.Id == courseId
                        select c;
            return query.ToList().First();
        }

    }
}
