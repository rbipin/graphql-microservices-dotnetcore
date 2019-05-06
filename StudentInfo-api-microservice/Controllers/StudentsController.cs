using Microsoft.AspNetCore.Mvc;
using StudentInfo_api_microservice.BusinessLayer;
using StudentInfo_api_microservice.Entity;
using System.Collections.Generic;

namespace StudentInfo_api_microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private StudentBiz studentBizLayer = new StudentBiz();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            return Ok(studentBizLayer.GetAllStudents());
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<Student> GetStudentInforById(int id)
        {
            var student = studentBizLayer.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
    }
}
