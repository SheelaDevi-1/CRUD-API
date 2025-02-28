using CurdProject.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CurdProject.Model;

namespace CurdProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody]Student s1)
        {
            _db.Add(s1);
            _db.SaveChanges();
            return Ok(s1);
        }
        
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            List<Student> students = new List<Student>();
            students = _db.Students.ToList();
            return Ok(students);
        }
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id)
        {
            Student s1 = _db.Students.FirstOrDefault(x => x.Id == id);//FirstOrDefault is used to get the first record from the table and x=> x.id means getting data from db
            return Ok(s1);
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update([FromBody]Student s1)
        {
            _db.Update(s1);
            _db.SaveChanges();
            return Ok(s1);
        }
        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int id)
        {
            Student s1 = _db.Students.FirstOrDefault(x => x.Id == id);
            _db.Remove(s1);
            _db.SaveChanges();
            return Ok(s1);
        }


    }
}
