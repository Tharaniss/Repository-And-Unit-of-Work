using Firebase.Entities.DBContext;
using Firebase.Entities.Models;
using Firebase.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firebase.Repository.Concrete
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly FirebaseDBContext db_context;

        public EmployeeRepository(FirebaseDBContext context): base(context)
        {
            this.db_context = context;
        }
    }
}
