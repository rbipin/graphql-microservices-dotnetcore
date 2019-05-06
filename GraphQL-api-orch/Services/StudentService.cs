using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL_api_orch.Domain;
using RestSharp;
using Newtonsoft.Json;

namespace GraphQL_api_orch.Services
{
    public class StudentService
    {
        const string apiRoute = "/api/students";
        public StudentInfo GetStudentInformationById(int id)
        {
            string apiRouteTemp = apiRoute + $"/{id}";
            StudentDetails studentDetails = new StudentDetails();
            var restshrapClient = new RestClient("http://localhost:5003");
            var request = new RestRequest(apiRouteTemp,Method.GET);
            var response = restshrapClient.Execute(request);
            var studentInfo = JsonConvert.DeserializeObject<StudentInfo>(response.Content);
            return studentInfo;
        }

        public IEnumerable<StudentInfo> GetAllStudents()
        {
            var restshrapClient = new RestClient("http://localhost:5003");
            var request = new RestRequest(apiRoute,Method.GET);
            var response = restshrapClient.Execute(request);
            var studentInfo = JsonConvert.DeserializeObject<List<StudentInfo>>(response.Content);
      
            return studentInfo;

        }
    }
}
