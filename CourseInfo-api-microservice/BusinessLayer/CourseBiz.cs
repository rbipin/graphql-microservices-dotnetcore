using CourseInfo_api_microservice.Entity;
using System.Collections.Generic;

namespace CourseInfo_api_microservice.BusinessLayer
{
    public class CourseBiz
    {
        List<Course> allCourseList = null;
        public CourseBiz()
        {
         allCourseList = new List<Course>
            {
                new Course{ Id=1000, CourseName="Object Oriented Programming"},
                new Course{ Id=2000, CourseName="Quantum Mechanics" },
                new Course{ Id=3000, CourseName="Applied Physics" },
                new Course{ Id=4000, CourseName="Ethical Hacking" },
                new Course{ Id=5000, CourseName="Electronics 101" },
                new Course{ Id=6000, CourseName="Communication Engineering" },
                new Course{ Id=7000, CourseName="Mathematics 101" }
            };
        }

        /// <summary>
        /// Get all the courses
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Course> GetAllCourse()
        {
            return allCourseList;
        }

        /// <summary>
        /// Get a Particular course by it's id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Course GetCourseById(int id)
        {
          return allCourseList.Find(x => x.Id == id);
        }
    }
}
