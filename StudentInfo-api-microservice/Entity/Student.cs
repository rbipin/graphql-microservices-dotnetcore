using System.Collections.Generic;

namespace StudentInfo_api_microservice.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        public IEnumerable<int> CourseId { get; set; }
    }
}
