using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using GraphQL_api_orch.Types;
using GraphQL_api_orch.Services;

namespace GraphQL_api_orch.Queries
{
    public class CoursesQuery: ObjectGraphType
    {
        CourseService courseService = new CourseService();
        public CoursesQuery()
        {
            Field<ListGraphType<CourseType>>(
                name: "Course",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name="id"}),
                resolve: context=>
                {
                    var id = context.GetArgument<int>("id");
                    return courseService.GetCourseDetailsById(id);
                }
                );
        }
    }
}
