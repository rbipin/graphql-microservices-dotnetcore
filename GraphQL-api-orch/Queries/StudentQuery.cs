using GraphQL.Types;
using GraphQL_api_orch.Services;
using GraphQL_api_orch.Types;

namespace GraphQL_api_orch.Queries
{
    public class StudentQuery : ObjectGraphType
    {
        InformationService infoService = new InformationService();
        
        public StudentQuery()
        {
            Field<StudentDetailsType>(
                name: "student",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return infoService.GetStudentById(id);
                }
                );
        }
    }
}
