using CourseInfo_api_microservice.Entity;
using System.Collections.Generic;


namespace CourseInfo_api_microservice.DataLayer
{
    public class CourseContext
    {
        private List<Course> _course = new List<Course>();
       public virtual List<Course> Course
        {
            get
            {
                return _course;
            }
            set
            {
                _course = value;
            }
        }
    }
}
