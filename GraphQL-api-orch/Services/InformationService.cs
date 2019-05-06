using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL_api_orch.Domain;

namespace GraphQL_api_orch.Services
{
    public class InformationService
    {
        public StudentService studentService { get; private set; }
        public CourseService courseService { get; set; }
        public InformationService()
        {
            studentService = new StudentService();
            courseService = new CourseService();
        }

        /// <summary>
        /// Get the student details by student id
        /// </summary>
        /// <param name="id">student id</param>
        /// <returns></returns>

        public StudentDetails GetStudentById(int id)
        {
            StudentDetails studentInformation = new StudentDetails();
            var student= studentService.GetStudentInformationById(id);
            studentInformation.Student = student;
            studentInformation.Courses = GetCoursesTakenByStudentId(id);
            return studentInformation;
        }

        public IEnumerable<Course> GetCoursesTakenByStudentId(int id)
        {
           
            var student = studentService.GetStudentInformationById(id);
            var courseIdList = student.CourseId;
            List<Course> courseDetails = null;
            foreach(var courseId in courseIdList)
            {
                courseDetails=new List<Course>();
                var course = courseService.GetCourseDetailsById(courseId);
                if (course!=null)
                {
                    courseDetails.Add(course);
                }
            }
            return courseDetails;
        }
    }
}
