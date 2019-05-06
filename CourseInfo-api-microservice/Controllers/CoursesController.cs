using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseInfo_api_microservice.BusinessLayer;
using CourseInfo_api_microservice.Entity;

namespace CourseInfo_api_microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private CourseBiz courseBizLayer = new CourseBiz();
        
       [HttpGet]
       public ActionResult<IEnumerable<Course>> GetAllCourses()
        {
            return Ok(courseBizLayer.GetAllCourse());
        }

        [HttpGet("{id}")]
        public ActionResult<Course> GetCourseById(int id)
        {
            var course = courseBizLayer.GetCourseById(id);
            if (course==null)
            {
                return NotFound();
            }
            return Ok(course);
        }
    }
}
