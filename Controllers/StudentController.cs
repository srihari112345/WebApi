using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Student")]
    public class StudentController : Controller
    {
        public List<StudentModel> Students { get; set; } = new List<StudentModel>(){
            new StudentModel()
            {
                    Name = "Srihari",
                    RollNo= "30",
                    Class = "12th"
            },
            new StudentModel()
            {
                    Name = "Hari",
                    RollNo = "20",
                    Class = "12th"
            }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Students);
        }

        [HttpGet("{rollNo}", Name = "Get")]
        public IActionResult Get(string rollNo)
        {
            var student = Students.FirstOrDefault(e => e.RollNo == rollNo);
            return Ok(student);
        }

        [HttpPost()]
        public IActionResult Post()
        {
           
            return Ok(Students);
        }

        [HttpPut("{rollNo}")]
        public IActionResult Put(string rollNo)
        {
            var student = Students.FirstOrDefault(e => e.RollNo == rollNo);
            student.Name = "Vishnu";
            return Ok(student);
        }
    }
}