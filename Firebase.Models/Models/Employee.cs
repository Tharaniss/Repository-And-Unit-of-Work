using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firebase.Entities.Models
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public DepartmentDTO Department { get; set; }
    }
}
