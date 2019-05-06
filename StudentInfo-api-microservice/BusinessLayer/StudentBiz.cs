using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentInfo_api_microservice.Entity;

namespace StudentInfo_api_microservice.BusinessLayer
{
    public class StudentBiz
    {
        private List<Student> allStudentsList = null;
        public StudentBiz()
        {
            allStudentsList = new List<Student>
            {
                new Student{
                    Id =1234, FirstName="John", LastName="Smith", Address="W Howard ST", ContactNumber="616-878-1478"
                    ,CourseId=new List<int>{
                            2000,
                            5000,
                            6000
                    }
                },
                new Student {
                    Id =1237,FirstName ="John", LastName="Doe", Address="E Fort St", ContactNumber="312-478-7895"
                    ,CourseId=new List<int>{
                        4000,
                        1000,
                        7000
                    }
                },
                new Student{
                    Id =1111, FirstName="James", LastName="Bond", Address="Woodward Ave", ContactNumber="616-897-7896"
                    ,CourseId=new List<int>{
                        6000,
                        7000,
                        3000
                    }
                },
                new Student{
                    Id =1222, FirstName="Peter", LastName="Parker", Address="Lafayatte Ave", ContactNumber="616-789-4589"
                    ,CourseId=new List<int>{
                        2000
                    }
                },
                new Student{
                    Id =3456, FirstName="Tony", LastName="Stark", Address="Monroe Ave", ContactNumber="616-157-8789"
                    ,CourseId=new List<int>{
                        4000,
                        3000,
                        1000,
                        7000,
                        2000
                    }
                }

            };
        }

        /// <summary>
        /// Return all the students
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> GetAllStudents()
        {
            return allStudentsList;
        }

        /// <summary>
        /// Get a single student
        /// </summary>
        /// <param name="id">Student id</param>
        /// <returns></returns>
        public Student GetStudentById(int id)
        {
            return allStudentsList.Find(x => x.Id == id);
        }
    }
}
