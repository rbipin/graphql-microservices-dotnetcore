using GraphQL;
using GraphQL.Types;
using GraphQL_api_orch.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GraphQL_api_orch.Controllers
{

    public class GraphQlQuery
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public Inputs Variables { get; set; }

    }

    [Route(Startup.GraphQlPath)]
    [ApiController]
    public class InformationController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQlQuery query)
        {
            var schema = new Schema { Query=new StudentQuery()};
            var result = await new DocumentExecuter().ExecuteAsync(x =>
              {
                  x.Schema = schema;
                  x.Query = query.Query;
                  x.Inputs = query.Variables;
              });

            if (result.Errors?.Count>0)
            {
                var error = new
                {
                    errorMessage = result.Errors.Select(x => x.InnerException.ToString())
                };
                return BadRequest(error);
            }
            return Ok(result);
        }
    }
}
