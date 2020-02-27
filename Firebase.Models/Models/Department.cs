using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firebase.Entities.Models
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<EmployeeDTO> Employees { get; set; }
    }
}
