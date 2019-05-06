using System.Collections.Generic;
namespace GraphQL_api_orch.Domain
{
    public class StudentDetails
    {
        public StudentInfo Student { get; set; }

        public IEnumerable<Course> Courses { get; set; }
    }
}
