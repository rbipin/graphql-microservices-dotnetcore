using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL_api_orch.Domain;
using RestSharp;
using Newtonsoft.Json;

namespace GraphQL_api_orch.Services
{
     
    public class CourseService
    {
        const string apiRoute = "/api/courses";
        public Course GetCourseDetailsById(int id)
        {
            string apiRouteTemp = apiRoute + $"/{id}";
            var restshrapClient = new RestClient("http://localhost:5002");
            var request = new RestRequest(apiRouteTemp, Method.GET);
            var response = restshrapClient.Execute(request);
            var courseInfo = JsonConvert.DeserializeObject<Course>(response.Content);
            return courseInfo;
        }

        public List<Course> GetAllCourse()
        {
            var restshrapClient = new RestClient("http://localhost:5002");
            var request = new RestRequest(apiRoute,Method.GET);
            var response = restshrapClient.Execute(request);
            var courseInfo = JsonConvert.DeserializeObject<List<Course>>(response.Content);
            return courseInfo;
        }
    }
}
