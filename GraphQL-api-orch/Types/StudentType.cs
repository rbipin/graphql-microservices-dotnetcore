using GraphQL.Types;
using GraphQL_api_orch.Domain;

namespace GraphQL_api_orch.Types
{
    public class StudentType: ObjectGraphType<StudentInfo>
    {
        public StudentType()
        {
            Field(x => x.Id).Description("Student Id");
            Field(x => x.FirstName).Description("First name of the student");
            Field(x => x.LastName).Description("Last name of the student");
            Field(x => x.ContactNumber).Description("Contact Number of the student");
            Field(x => x.Address).Description("Address of the student");
            Field(x => x.CourseId).Description("Course Id");
        }
    }
}
