using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using GraphQL_api_orch.Domain;

namespace GraphQL_api_orch.Types
{
    public class StudentDetailsType: ObjectGraphType<StudentDetails>
    {
        public StudentDetailsType()
        {
            Field<StudentType>("student");
            Field<ListGraphType<CourseType>>("courses");
        }
    }
}
