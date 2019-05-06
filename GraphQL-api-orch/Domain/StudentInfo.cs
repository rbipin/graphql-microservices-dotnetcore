using System.Collections.Generic;

namespace GraphQL_api_orch.Domain
{
    public class StudentInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        public IEnumerable<int> CourseId { get; set; }
    }
}
