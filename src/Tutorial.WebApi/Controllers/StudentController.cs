using Microsoft.AspNetCore.Mvc;
using Tutorial.Application.Dtos;
using Tutorial.Application.Interface;
using Tutorial.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tutorial.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public ValuesController(IStudentService studentService)
        {
            _studentService= studentService;    
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] StudentDto model)
        {
            var student = new Student
            {
                FirstName= model.FirstName,
                LastName= model.LastName,   
                Mobile= model.Mobile,
                NationalId= model.NationalId,
                FatherName= model.FatherName,   
            };
            
            var stu=_studentService.CreateStudent(student);

            return Ok(stu);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
