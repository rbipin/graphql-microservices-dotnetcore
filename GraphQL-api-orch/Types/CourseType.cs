using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQL_api_orch.Domain;

namespace GraphQL_api_orch.Types
{
    public class CourseType:ObjectGraphType<Course>
    {
        public CourseType()
        {
            Field(x => x.Id).Description("Course Id");
            Field(x => x.CourseName).Description("Name of the Course");
        }
        
    }
}
