using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Entities.DBContext;
using Firebase.Entities.Models;
using Firebase.Repository.Abstract;
using Firebase.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirebaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IBusinessService _businessService;

        public EmployeeController(IBusinessService businessService)
        {
            this._businessService = businessService;
        }

        // GET: api/Employee
        [HttpGet]
        public IEnumerable<EmployeeDTO> Get()
        {
            return _businessService.EmployeeService.GetEmployee();
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Employee
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
