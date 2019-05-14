using CourseInfo_api_microservice.DataLayer;
using CourseInfo_api_microservice.Entity;
using System.Collections.Generic;

namespace CourseInfo_api_microservice.BusinessLayer
{
    public class CourseBiz
    {
        CourseService courseServiceRepo = null;
        public CourseBiz()
        {
            CourseContext courseCon = new CourseContext();
            courseServiceRepo = new CourseService(courseCon);
            //Setup some test data
            SetupTestData();
        }

        private void SetupTestData()
        {
            //Add the courses
            courseServiceRepo.AddCourse(new Course { Id = 1000, CourseName = "Object Oriented Programming" });
            courseServiceRepo.AddCourse(new Course { Id = 3000, CourseName = "Applied Physics" });
            courseServiceRepo.AddCourse(new Course { Id = 4000, CourseName = "Ethical Hacking" });
            courseServiceRepo.AddCourse(new Course { Id = 5000, CourseName = "Electronics 101" });
            courseServiceRepo.AddCourse(new Course { Id = 2000, CourseName = "Quantum Mechanics" });
            courseServiceRepo.AddCourse(new Course { Id = 6000, CourseName = "Communication Engineering" });
            courseServiceRepo.AddCourse(new Course { Id = 7000, CourseName = "Mathematics 101" });
        }

        /// <summary>
        /// Get all the courses
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Course> GetAllCourse()
        {
            return courseServiceRepo.GetAllCourses();
        }

        /// <summary>
        /// Get a Particular course by it's id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Course GetCourseById(int id)
        {
            return courseServiceRepo.GetACourse(id);
        }
    }
}
